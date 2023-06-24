# List in python

|||
|---|---|
|Ordered          | ✅|
|Changeable       | ✅|
|Duplicate values | ✅|
___________________________________________________________

## *List methods*
| Method | Description |
| --- | --- |
| append() | Adds an element at the end of the list |
| clear() | Removes all the elements from the list |
| copy() | Returns a copy of the list |
| count() | Returns the number of elements with the specified value |
| extend() | Add the elements of a list (or any iterable), to the end of the current list |
| index() | Returns the index of the first element with the specified value |
| insert() | Adds an element at the specified position |
| pop() | Removes the element at the specified position |
| remove() | Removes the item with the specified value |
| reverse() | Reverses the order of the list |
| sort() | Sorts the list |

___________________________________________________________


## *Define list*
###### *code :-*
```py
myList = [1, 4, 3, 2]
print(myList)
myList2 = list((2, 1, 4, 3)) # using constructor
print(myList2)
myList3 = [5, 2, "seven", 7.9] # can contain value with different data types
print(myList3)
```
###### *output :-*
```
[1, 4, 3, 2]
[2, 1, 4, 3]
[5, 2, 'seven', 7.9]
```
___________________________________________________________


## *Length and type*
###### *code :-*
```py
myList = [1, 2, 3, 4]
print(len(myList))
print(type(myList))
```
###### *output :-*
```
4
<class 'list'>
```
___________________________________________________________


## *Access elements*
```py
myList = [1, 2, 3, 4, 5]

print(myList[0])      # 1
print(myList[4])      # 5
# Negative Indexing
print(myList[-1])     # 5
print(myList[-5])     # 1
# 😵‍💫🤯👾 Range of Indexes
print(myList[1:3])    # [2, 3]
print(myList[3:1])    # []
print(myList[2:])     # [3, 4, 5]
print(myList[-3:-1])  # [3, 4]
print(myList[-1:-3])  # []
print(myList[-3:])    # [3, 4, 5]
print(myList[1:-1])   # [2, 3, 4]
print(myList[-1:1])   # []
print(myList[0:len(myList)])   # [1, 2, 3, 4, 5]
print(myList[:])   # [1, 2, 3, 4, 5]
```
___________________________________________________________

## *Search item*
###### *code :-*
```py
myList = [1, 2, 3, 4, 5]
x = 3

if x in myList:
    print(f"{x} is present in list")

print(f"{x} is at index", myList.index(x))
```
###### *output :-*
```
3 is present in list
3 is at index 2
```
___________________________________________________________

## *Adding element*
###### *code 1 :-*
```py
fruits = ["apples", "oranges"]
print(fruits)

fruits.append("grapes")
print(fruits)
fruits.insert(1,"kiwi")
print(fruits)
fruits.insert(52,"watermelon")
print(fruits)
```
###### *output 1 :-*
```
['apples', 'oranges']
['apples', 'oranges', 'grapes']
['apples', 'kiwi', 'oranges', 'grapes']
['apples', 'kiwi', 'oranges', 'grapes', 'watermelon']
```
###### *code 2 :-*
```py
fruits = ["apples", "oranges", "grapes"]
print(fruits)

fruits.insert(-1,"kiwi")
print(fruits)
fruits.insert(-52,"watermelon") # insert at first if it's value less than or equal to the negative size of the list.
print(fruits)
```
###### *output 2 :-*
```
['apples', 'oranges', 'grapes']
['apples', 'oranges', 'kiwi', 'grapes']
['watermelon', 'apples', 'oranges', 'kiwi', 'grapes']
```
###### *code 3 :-*
```py
fruits = ["apples", "oranges"]

fruits_set = {"grapes", "tomato"}
fruits.extend(fruits_set)
print(fruits)

fruits_tuple = ("kiwi", "mango")
fruits.extend(fruits_tuple)
print(fruits)

fruits_dict = {"f1":"pineapple","f2":"watermelon"}
fruits.extend(fruits_dict.values())
```
###### *output 3 :-*
```
['apples', 'oranges', 'tomato', 'grapes']
['apples', 'oranges', 'tomato', 'grapes', 'kiwi', 'mango']
['apples', 'oranges', 'tomato', 'grapes', 'kiwi', 'mango', 'pineapple', 'watermelon']
```
___________________________________________________________


## [*Change List items(update)*](https://www.w3schools.com/python/python_lists_change.asp)
```py
myList = [1, 2, 3, 4, 5, 6]

myList[1:1] = ["👾", "👻"]  # [1, '👾', '👻', 2, 3, 4, 5, 6]

myList[1:2] = ["👾", "👻"]  # [1, '👾', '👻', 3, 4, 5, 6]

myList[1:3] = ["👾", "👻"]  # [1, '👾', '👻', 4, 5, 6]

myList[1:0] = ["👾", "👻"]  # [1, '👾', '👻', 2, 3, 4, 5, 6]

myList[0:0] = ["👾", "👻"]  # ['👾', '👻', 1, 2, 3, 4, 5, 6]

myList[0:-1] = ["👾", "👻"]  # ['👾', '👻', 6]

myList[1:-1] = ["👾", "👻"] # [1, '👾', '👻', 6]

myList[-1:1] = ["👾", "👻"] # [1, 2, 3, 4, 5, '👾', '👻', 6]

myList[len(myList):] = ["👾", "👻"] # [1, 2, 3, 4, 5, 6, '👾', '👻']

myList[0:len(myList)] = ["👾", "👻"] # ['👾', '👻']

myList[:] = ["👾", "👻"] # ['👾', '👻']
```
___________________________________________________________


## *Remove List Items*
###### *code 1 :-*
```py
fruits = ["apples", "kiwi", "mango", "kiwi"]
print()

fruits.remove("kiwi")  # Remove the first occurrence of "kiwi" from the list

# fruits.remove("ABCD")  # 👾 ERROR : ValueError
```
###### *output 1 :-*
```
['apples', 'kiwi', 'mango', 'kiwi']
['apples', 'mango', 'kiwi']
```
###### *code 2 :-*
```py
fruits = ["apples", "watermelon", "mango", "kiwi"]

del fruits[1]  # ['apples', 'mango', 'kiwi']

del fruits[-1] # ['apples', 'watermelon', 'mango']

del fruits[52] #  👾 ERROR : IndexError
del fruits[-52] #  👾 ERROR : IndexError

del fruits[1:3] # ['apples', 'kiwi']

del fruits[-3:-1] # ['apples', 'kiwi']
```
###### *code 3 :-*
```py
fruits.clear() # remove all elements

del fruits[:] # remove all elements

del fruits  # delete the list completely
# print(fruits)  # 👾 ERROR : NameError
```
___________________________________________________________


## *Loop Lists*
```py
myList = [10, 20, 30, 40, 50,]

for x in myList:
    print(x, end=" ") # 10 20 30 40 50

for i in range(len(myList)):
    print(myList[i], end=" ") # 10 20 30 40 50

i = 0
while i < len(myList):
    print(myList[i], end=" ") # 10 20 30 40 50
    i = i + 1

[print(x, end=" ") for x in myList] # 10 20 30 40 50
```
___________________________________________________________


## *List Comprehension*
##### *Syntax :-*
```py
new_list = [expression for item in iterable if condition == True]
```
###### *code 1 :-*
```py
myList = [1, 2, 3, 4, 5]

newList = [i for i in myList]  # duplicate list and store in newList
print(newList)
```
###### *output 1 :-*
```
[1, 2, 3, 4, 5]
[100, 200, 300, 400, 500]
```
###### *code 2 :-*
```py
fruits = ['apples', 'cherry', 'banana', "kiwi"]

newList = [x for x in fruits if "a" in x] # new list having items that contains 'a' latter
print(newList)
```
###### *output 2 :-*
```
['apples', 'banana']
```
###### *code 3 :-*
```py
newList = [x for x in range(11)] # create list using range()
print(newList)

evenNums = [x for x in range(11) if x % 2 == 0] # create list with even numbers only with if condition
print(evenNums)

[print(x, end=", ") for x in range(11) if x % 2 != 0] # direct printing odd numbers
```
###### *output 3 :-*
```
[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
[0, 2, 4, 6, 8, 10]
1, 3, 5, 7, 9,
```
___________________________________________________________


## *Sorting list*
###### *code :-*
```py
myList = [1, 4, 3, 2]
myList.sort() # ascending
print(myList)
myList.sort(reverse=True) # descending
print(myList)
myList.reverse() # descending
print(myList)
print(myList[::-1])
```
###### *output :-*
```
[1, 2, 3, 4]
[4, 3, 2, 1]
[1, 2, 3, 4]
[4, 3, 2, 1]
```
___________________________________________________________


## *Customize Sorting function*
###### *code 1 :-*
```py
fruits = ["apple", "Banana", "Kiwi", "watermelon", "Mango"]

fruits.sort() # By default the sort() method is case sensitive
print(fruits)

fruits.sort(key=str.lower) # We can use str.lower builtin string method to sort with case insensitive
print(fruits)

fruits.sort(key=len) # Sort the list based on the length of element
print(fruits)
```
###### *output 1 :-*
```
['Banana', 'Kiwi', 'Mango', 'apple', 'watermelon']
['apple', 'Banana', 'Kiwi', 'Mango', 'watermelon']
['Kiwi', 'apple', 'Mango', 'Banana', 'watermelon']
```
###### *code 2 :-*
```py
def getQuantity(item):
    return item[1]
    
cart_items = [
    ("apple", 3), ("banana", 2), ("pear", 5), ("orange", 1)
]

cart_items.sort(key=getQuantity)

print(cart_items)
```
###### *output 2 :-*
```
[('orange', 1), ('banana', 2), ('apple', 3), ('pear', 5)]
```
<!-- def myFunc(n):
  return abs(n - 50)

thisList = [100, 50, 65, 82, 23]
thisList.sort(key = myFunc)
print(thisList) -->

<!-- [50, 65, 23, 82, 100] -->

___________________________________________________________


## *Copy list*
```py
fruits = ['watermelon', 'grapes', 'mango']

f1 = fruits.copy()

f2 = list(fruits)

f3 = [x for x in fruits]

fruits_ref = fruits # assign reference of fruits to f1, so don't use this to copy
```
___________________________________________________________


## *Join list*
```py
list1 = ["a", "b", "c"]
list2 = [1, 2, 3]

# method 1
for x in list2:
    list1.append(x)

# method 2
newList = list1 + list2

# method 3
list1.extend(list2)
```
___________________________________________________________


## *count()*
###### *code :-*
```py
fruits = ["apple", "kiwi", "mango", "watermelon", "kiwi"]

print(fruits.count("kiwi")) # 2

print(fruits.count("mango")) # 1

print(fruits.count("abcd")) # 0
```
___________________________________________________________


## *index()*
##### *Syntax :-*
```py
list.index(element, start, end)
```
###### *code :-*
```py
fruits = ["apple", "banana", "kiwi", "mango", "watermelon",
          "kiwi", "cherry", "grapes", "kiwi", "apple"]

print(fruits.index("kiwi"))

print(fruits.index("kiwi", 3, 6)) # Finding the index of a specific element in a list within a certain range

print(fruits.index("kiwi", 6)) # find item from given start index till the end of the list

print(len(fruits) - fruits[::-1].index("kiwi") - 1) # find the index of the last occurrence of an element in a list
```
###### *output :-*
```
2
5
8
8
```
___________________________________________________________


## *Remaining slicing*
```py
myList = [1, 2, 3, 4, 5]

myList[0::]   # [1, 2, 3, 4, 5]
myList[1::]   # [2, 3, 4, 5]
myList[2::]   # [3, 4, 5]
myList[5::]   # []
myList[6::]   # []
myList[-1::]  # [5]
myList[-2::]  # [4, 5]
myList[-5::]  # [1, 2, 3, 4, 5]
myList[-6::]  # [1, 2, 3, 4, 5]

myList[::0]   # 👾 ERROR : ValueError
myList[::1]   # [1, 2, 3, 4, 5]
myList[::2]   # [1, 3, 5]
myList[::5]   # [1]
myList[::6]   # [1]
myList[::-1]  # [5, 4, 3, 2, 1]
myList[::-2]  # [5, 3, 1]
myList[::-5]  # [5]
myList[::-6]  # [5]

myList[:0:]   # 👾 ERROR : ValueError
myList[:1:]   # [1]
myList[:2:]   # [1, 2]
myList[:5:]   # [1, 2, 3, 4, 5]
myList[:6:]   # [1, 2, 3, 4, 5]
myList[:-1:]  # [1, 2, 3, 4]
myList[:-2:]  # [1, 2, 3]
myList[:-5:]  # []
myList[:-6:]  # []

```

___________________________________________________________




<!-- 
## *Remaining slicing*
###### *code :-*
```py
# fruits = [1, 2, 3, 4, 5]

# print(fruits[0::])
# print(fruits[:0:]) # 👾 ERROR : ValueError
# print(fruits[::0]) # 👾 ERROR : ValueError
# print()
```
###### *output :-*
```

```
###### *code :-*
```py
# fruits = [1, 2, 3, 4, 5]

# print(fruits[1::])
# print(fruits[:1:])
# print(fruits[::1])
# print()
# print(fruits[2::])
# print(fruits[:2:])
# print(fruits[::2])
# print()
# print(fruits[5::])
# print(fruits[:5:])
# print(fruits[::5])
# print()
# print(fruits[6::])
# print(fruits[:6:])
# print(fruits[::6])
# print()
```
###### *output :-*
```

```
###### *code :-*
```py
# fruits = [1, 2, 3, 4, 5]

# print(fruits[-1::])
# print(fruits[:-1:])
# print(fruits[::-1])
# print()
# print(fruits[-2::])
# print(fruits[:-2:])
# print(fruits[::-2])
# print()
# print(fruits[-5::])
# print(fruits[:-5:])
# print(fruits[::-5])
# print()
# print(fruits[-6::])
# print(fruits[:-6:])
# print(fruits[::-6])
# print()
```
###### *output :-*
```

``` -->