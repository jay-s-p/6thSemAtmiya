"""
1.3 Write a program to find maximum and minimum from 3 entered numbers.
"""
a = int(input("Enter a : "))
b = int(input("Enter b : "))
c = int(input("Enter c : "))

min = max = a
for i in [a, b, c]:
    if i > max:
        max = i
    if i < min:
        min = i

print(min, "is min")
print(max, "is max")


""" O/P:-
Enter a : 3
Enter b : 1
Enter c : 2
1 is min
3 is max
"""
