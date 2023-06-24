"""
 12.1 Write a program to demonstrate file handling.
"""

try:
    lowerTxt = open("./lower.txt", "r")
    upperTxt = open("./upper.txt", "a")

    upperTxt.truncate(0)

    for i in lowerTxt:
        upperTxt.write(i.upper())
    
    print("File copied Successfully!")
except Exception as e:
    print("ERROR :", str(e))
finally:
    lowerTxt.close()
    upperTxt.close()
