"""
3.1 Write a program to perform searching and sorting in given list.
"""
# Searching

list = ["Jay", "Harshad", "Dhruv", "Mohit", 1, 0, 8, 4, 3, 2]

print(list)
a = input("Enter value : ")
pos = -1
for i in range(0, len(list)):
    if a == str(list[i]).lower():
        pos = i

if pos == -1:
    print(a, "is not found")
else:
    print(a, "is found at", pos + 1, "position.")


# Sorting

list = [1, 0, 8, 4, 3, 2]
print("\nOriginal list : ", list)
for i in range(len(list) - 1):
    if list[i] > list[i + 1]:
        list[i], list[i + 1] = list[i + 1], list[i]
print("Sorted list   : ", list)


""" O/P:-
['Jay', 'Harshad', 'Dhruv', 'Mohit', 1, 0, 8, 4, 3, 2]
Enter value : jay
jay is found at 1 position.

Original list :  [1, 0, 8, 4, 3, 2]
Sorted list   :  [0, 1, 4, 3, 2, 8]
"""
