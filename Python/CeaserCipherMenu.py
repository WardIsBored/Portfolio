import customtkinter as ctk

# Setup menu
ctk.set_appearance_mode("dark")
ctk.set_default_color_theme("dark-blue")
app = ctk.CTk()
app.geometry("420x450")
app.title("CeaserCipher Menu")

# Text
text = ctk.CTkLabel(app, text="CeaserCipher: ")
text.pack(padx=20, pady=10)
text._font.configure(size=20)

# TextBoxes
encryptionBox = ctk.CTkTextbox(app, width=500, height=40)
encryptionBox.pack(padx=20, pady=10)
encryptionBox.insert("0.0", "Encryption")

shiftBoxE = ctk.CTkTextbox(app, width=500, height=40)
shiftBoxE.pack(padx=20, pady=10)
shiftBoxE.insert("0.0", "Shift")

decryptionBox = ctk.CTkTextbox(app, width=500, height=40)
decryptionBox.pack(padx=20, pady=10)
decryptionBox.insert("0.0", "Decryption")

shiftBoxD = ctk.CTkTextbox(app, width=500, height=40)
shiftBoxD.pack(padx=20, pady=10)
shiftBoxD.insert("0.0", "Shift")

# Labels
consoleLabel = ctk.CTkLabel(app, text="Console: ")
consoleLabel.pack(padx=20, pady=10)
consoleLabel._font.configure(size=20)

# Buttons and functions
def encrypt():
    text = encryptionBox.get("0.0", "end-1c")
    shift = shiftBoxE.get("0.0", "end-1c")
    if not shift.isdigit():
        encryptionBox.delete("0.0", "end")
        encryptionBox.insert("0.0", "Please enter a valid number(INTEGER)")
        consoleLabel.configure(text="Console: Please enter a valid number (INTEGER)")
        return
    shift = int(shift)
    result = ""
    for char in text:
        if char.isalpha():
            start = ord('A') if char.isupper() else ord('a')
            result += chr((ord(char) - start + shift) % 26 + start)
        else:
            result += char
    decryptionBox.delete("0.0", "end")
    decryptionBox.insert("0.0", result)
    consoleLabel.configure(text=f"Console: {result}")

def decrypt():
    text = decryptionBox.get("0.0", "end-1c")
    shift = shiftBoxD.get("0.0", "end-1c")
    if not shift.isdigit():
        decryptionBox.delete("0.0", "end")
        decryptionBox.insert("0.0", "Please enter a valid number(INTEGER)")
        consoleLabel.configure(text="Console: Please enter a valid number (INTEGER)")
        return
    shift = int(shift)
    result = ""
    for char in text:
        if char.isalpha():
            start = ord('A') if char.isupper() else ord('a')
            result += chr((ord(char) - start - shift) % 26 + start)
        else:
            result += char
    encryptionBox.delete("0.0", "end")
    encryptionBox.insert("0.0", result)
    consoleLabel.configure(text=f"Console: {result}")

encryptButton = ctk.CTkButton(app, text="Encrypt", command=encrypt)
encryptButton.pack(padx=20, pady=10)
decryptButton = ctk.CTkButton(app, text="Decrypt", command=decrypt)
decryptButton.pack(padx=20, pady=10)

app.mainloop()