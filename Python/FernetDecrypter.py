from cryptography import fernet
import os

def Decrypt(key, etm):  # encrypted to message
    f = fernet.Fernet(key)
    decryptedmessage = f.decrypt(etm)
    print("Decrypted (bytes): ", decryptedmessage, "\n")
    print("Decrypted (string): ", decryptedmessage.decode(), "\n")
    return decryptedmessage

def function():
    key = input("Enter key: ")
    etm = input("Enter encrypted message: ")
    key = key.encode()
    etm = etm.encode()
    Decrypt(key, etm)
    input("Press Enter to continue...")
    os.system('cls' if os.name == 'nt' else 'clear')
    function()
function()