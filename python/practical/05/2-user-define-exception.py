"""
5.2 Handle any user define exception.
"""

class AgeException(Exception):
    def __init__(self):
        super()

try:
    age = int(input("Enter your age : "))
    if age < 18:
        raise AgeException
except AgeException:
    print("You are not eligible to vote :(")
except Exception:
    print("An error occurred!")
else:
    print("You are eligible to vote :)")

""" O/P:-
Enter your age : 18
You are eligible to vote :)
"""

""" O/P 2:-
Enter your age : 17
You are not eligible to vote :(
"""

""" O/P 3:-
Enter your age : abcd
An error occurred!
"""
