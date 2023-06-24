"""
4.2 Write a program using user define function to
print fibonacci series.
"""

def fibonacci_series(n):
    a, b = 0, 1
    for i in range(n):
        print(a, end=' ')
        a, b = b, a + b


value = int(input("Enter no : "))
if value < 0:
    exit("Invalid value!")
fibonacci_series(value)

""" O/P:-
Enter no : 10
0 1 1 2 3 5 8 13 21 34 
"""
