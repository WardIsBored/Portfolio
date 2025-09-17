import os

def caesar_decrypt(ciphertext, shift):
    result = ""
    for char in ciphertext:
        if char.isalpha():
            shift_base = ord('A') if char.isupper() else ord('a')
            result += chr((ord(char) - shift_base - shift) % 26 + shift_base)
        else:
            result += char
    return result

def caesar_bruteforce():
    encrypted_message = input("Please input the encoded message you would like to decode: ")  # Example encrypted message
    for key in range(1, 26):
        decrypted = caesar_decrypt(encrypted_message, key)
        print(f"Key {key}: {decrypted}")
    input("Press Enter to continue...")
    os.system("cls" or "clear") 
    caesar_bruteforce()
caesar_bruteforce()