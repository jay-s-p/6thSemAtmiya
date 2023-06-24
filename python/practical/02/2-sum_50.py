"""
2.2 Write a program to print sum of first 50 numbers with different loops.
"""

print("Sum of first 50 numbers :-")
sum = 0
for i in range(1, 51):
    sum += i
print("using for loop   :", sum)

i = 1
sum = 0
while i <= 50:
    sum += i
    i += 1
print("using while loop :", sum)


""" O/P:-
Sum of first 50 numbers :-
using for loop   : 1275
using while loop : 1275
"""