"""
4.1 Write a program using user define function to
print factorial series.
"""


def factorial_iterative_while(value):
    fact = 1
    while value > 1:
        fact *= value
        value -= 1
    return fact


def factorial_iterative_for(value):
    fact = 1
    for i in range(1, value + 1):
        fact *= i
    return fact


def factorial_recursion(value):
    return 1 if (value == 0 or value == 1) else value * factorial_recursion(value - 1)


value = int(input("Enter no : "))

if value < 0:
    exit("Invalid value!")

for i in range(0, value + 1):
    print(str(i)+"! =", factorial_recursion(i))

""" O/P:-
Enter no : 5 
0! = 1
1! = 1
2! = 2
3! = 6
4! = 24
5! = 120
"""
