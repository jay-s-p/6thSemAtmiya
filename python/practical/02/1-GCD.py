"""
2.1 Write a program to find GCD of two numbers.
"""
# Greatest Common Divisor
# Highest Common Factor

a = int(input("Enter a : "))
b = int(input("Enter b : "))

cd = 0
for i in range(1, min(a, b) + 1):
    if a % i == 0 and b % i == 0:
        cd = i

print("GCD is", cd)

""" O/P:-
Enter a : 12
Enter b : 18
GCD is 6
"""

""" O/P 2:-
Enter a : 6
Enter b : 9
GCD is 3
"""

""" O/P 3-
Enter a : 5
Enter b : 2
GCD is 1
"""
