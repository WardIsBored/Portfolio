from cryptography.fernet import Fernet
import os

def Encrypt(mte):  # message to encrypt
    key = Fernet.generate_key()
    f = Fernet(key)
    fernetmessage = f.encrypt(mte)
    print("Key: ", key, "\n")
    print("Encrypted (bytes): ", fernetmessage, "\n")
    return key, fernetmessage

def function():
    message = input("Enter message to encrypt: ")
    message = message.encode()
    key, encrypted = Encrypt(message)
    # If you want to see the bytes, they're in 'encrypted'
    input("Press Enter to continue...")
    os.system('cls' if os.name == 'nt' else 'clear')
    function()
function()
