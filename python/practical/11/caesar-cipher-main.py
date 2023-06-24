"""
11. Implement classical ciphers using python.
"""


def encrypt(plaintext, key):
    cifertext = ""
    for i in plaintext:
        if i == " ":
            cifertext += " "
        else:
            cifertext += chr(((ord(i) + key) - 65) % 26 + 65)if i.isupper() else chr(((ord(i) + key) - 97) % 26 + 97)
    return cifertext


plaintext = input("Enter a text : ")
key = int(input("Enter a key  : "))

print("Encrypted text :", encrypt(plaintext, key))
