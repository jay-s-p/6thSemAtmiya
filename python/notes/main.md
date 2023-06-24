<!-- 
todo: random, docstring, len(), string methods, break, continue, pass
-->


## *Hello World*
###### *code :-*
```py
print("👋 Hello, World 🌏!")
```
###### *output :-*
```
👋 Hello, World 🌏!
```
___________________________________________________________


## *Comments*
###### *code :-*
```py
# This is single line comment
# print("World, Hello!") 
print("👋 Hello, Python 🐍!") 
'''
THIS IS
MULTILINE
COMMENT (we can use ' or ")
'''
```
###### *output :-*
```
👋 Hello, Python 🐍!
```
___________________________________________________________


## *print function*
###### *code :-*
```py
""" print() Syntax :-
print(*values, sep=" ", end="\n", file=sys.stdout, flush=False)
"""
print("^_^") # Output a string

x = 52
print(x) # Output a variable

y = "Python"
print("I love", y)  # Output multiple objects

print("lol", "hmm", "ok", sep=", ") # Change the separator

# Change the ending
print("Hello", end=", ")
print("world!")

# Output to a file
f = open("output.txt", "w")
print("THIS IS DATA", file=f)
f.close()
```
###### *output :-*
```
^_^
52
I love Python
lol, hmm, ok
Hello, world!
```
___________________________________________________________


## *Print with formatted text*
###### *code :-*
```py
a, b = 5, 2

print((a), "+", b, "=", a+b)
print(f"{a} + {b} = {a+b}")
print("{} + {} = {}".format(a, b, a+b))
print("%d + %d = %d" % (a, b, a+b))
```
###### *output :-*
```
5 + 2 = 7
5 + 2 = 7
5 + 2 = 7
5 + 2 = 7
```
___________________________________________________________


## *Variables*
###### *code :-*
```py
# Syntax : variable_name = value

name = "Jay"
age = 20
print(name, age)

# Assign multiple values to multiple variables 
a, b, c = 1, 2, 3
print(a, b, c)
```
###### *output :-*
```
Jay 20
1 2 3
```
___________________________________________________________


## *Casting*
###### *code :-*
```py
x = str(3)    # x will be '3'
y = int(3)    # y will be 3
z = float(3)  # z will be 3.0
```
___________________________________________________________


## *Get types*
###### *code :-*
```py
print(type(5))
print(type(5.2))
print(type("Hmm"))
print(type('Okay'))
```
###### *output :-*
```
<class 'int'>
<class 'float'>
<class 'str'>
<class 'str'>
```
___________________________________________________________


## *Assign Multiple Values*
###### *code :-*
```py
# Many Values to Multiple Variables
x, y, z = "❌", "💛", "💤"
print(x, y, z)

# One Value to Multiple Variables
a = b = c = "🌈"
print(a, b, c)
```
###### *output :-*
```
❌ 💛 💤
🌈 🌈 🌈
```
___________________________________________________________


## *Outputting variables*
###### *code :-*
```py
x, y, z = "lol" ,"hmm" ,"ok"
print(x, y, z)
print(x + y + z)

a, b = 1, "two"
# print(a + b) # 👾 ERROR : TypeError
print(a, b)  # automatically convert to string before printing
```

###### *output :-*
```
lol hmm ok
lolhmmok
1 two
```
___________________________________________________________


## *Unpack collection to variables*
###### *code :-*
```py
x, y, z = ["apple", "banana", "cherry"] # List
print(x, y, z)
x, y, z = ("apple", "banana", "cherry") # Tuple
print(x, y, z)
x, y, z = {"apple", "banana", "cherry"} # Set
print(x, y, z)
```
###### *output :-*
```
apple banana cherry
apple banana cherry
cherry banana apple
```
💡 **Note**: Set returns values in random sequence each time program runs.
___________________________________________________________


## *Global variable*
###### *code 1 :-*
```py
x = "🌏"  # global variable

def myFunc():
    x = "🌈"  # local variable
    print(x)

print(x)
myFunc()
print(x)
```
###### *output 1 :-*
```
🌏
🌈
🌏
```
###### *code 2 :-*
```py
x = "🌏" # global variable

def myFunc():
    global x # Use the "global" keyword to access the global variable x
    x = "🌈" # assign value to global variable
    print(x)    

print(x)
myFunc()
print(x)
```
###### *output 2 :-*
```
🌏
🌈
🌈
```
___________________________________________________________


## *Data types python*

```py
        |
   _______________________________________________________________________________
   |           |           |           |         |                |              |
Numeric     Boolean     Sequential  Mapping     Sets            Binary       - None
- int       - bool      - list      - dict      - set           - bytes
- float                 - tuple                 - frozenset     - bytearray
- complex               - range                                 - memoryview
```
###### *code 1 :-*
```py
print(20) # int
print(20.5) # float
print(1j) # complex
print("Hello World") # str
print(["apple", "banana", "cherry"]) # list
print(("apple", "banana", "cherry")) # tuple
print(range(6)) # range
print({"name" : "John", "age" : 36}) # dict
print({"apple", "banana", "cherry"}) # set
print(frozenset({"apple", "banana", "cherry"})) # frozenset
print(True) # bool
print(b"Hello") # bytes
print(bytearray(5)) # bytearray
print(memoryview(bytes(5))) # memoryview
print(None) # None
```
###### *output 1 :-*
```
20
20.5
1j
Hello World
['apple', 'banana', 'cherry']
('apple', 'banana', 'cherry')
range(0, 6)
{'name': 'John', 'age': 36}
{'banana', 'apple', 'cherry'}
frozenset({'banana', 'apple', 'cherry'})
True
b'Hello'
bytearray(b'\x00\x00\x00\x00\x00')
<memory at 0x000001F98DB35D80>
None
```
###### *code 2 (using Constructor) :-*
```py
print(int(20)) # int
print(float(20.5)) # float
print(complex(1j)) # complex
print(str("Hello World")) # str
print(list(("apple", "banana", "cherry"))) # list
print(tuple(("apple", "banana", "cherry"))) # tuple
print(dict(name="John", age=36)) # dict
print(set(("apple", "banana", "cherry"))) # set
print(bool(5)) # bool
print(bytes(5)) # bytes
```
###### *output 2 :-*
```
20
20.5
1j
Hello World
['apple', 'banana', 'cherry']
('apple', 'banana', 'cherry')
{'name': 'John', 'age': 36}
{'apple', 'banana', 'cherry'}
True
b'\x00\x00\x00\x00\x00'
```
💡 **Tip**: We can also perform casting by using constructor functions

###### *code 3 (casting using Constructor) :-*
```py
print(int(20)) # int
print(float(20.5)) # float
print(complex(1j)) # complex
print(str("Hello World")) # str
print(list(("apple", "banana", "cherry"))) # list
print(tuple(("apple", "banana", "cherry"))) # tuple
print(dict(name="John", age=36)) # dict
print(set(("apple", "banana", "cherry"))) # set
print(bool(5)) # bool
print(bytes(5)) # bytes
```
###### *output 3 :-*
```
20
20.5
1j
Hello World
['apple', 'banana', 'cherry']
('apple', 'banana', 'cherry')
{'name': 'John', 'age': 36}
{'apple', 'banana', 'cherry'}
True
b'\x00\x00\x00\x00\x00'
```
___________________________________________________________


## *Strings*
###### *code :-*
```py
print("Double quotes string")
print('Single quotes string')
print("""
Multi line 
Double quotes string
""")
print('''
Multi line 
Single quotes string
''')
```
###### *output :-*
```
Double quotes string
Single quotes string

Multi line 
Double quotes string


Multi line 
Single quotes string
```
___________________________________________________________


## *Strings are Arrays*
###### *code :-*
```py
a = "Hello, World!"
print(a[2]) # 💡 index starts form zero
# print(a[52]) # 👾 ERROR : IndexError
```
###### *output :-*
```
e
```
___________________________________________________________


## *Looping Through a String*
###### *code :-*
```py
for x in "banana":
  print(x, end=" ")
```
###### *output :-*
```
b a n a n a 
```
___________________________________________________________


## *String Slicing*
###### *code :-*
```py
s = "Hello, World!"
print(" 2: 5\t→", s[2:5])
print(" 5: 2\t→", s[5:2])
print("-2:-5\t→", s[-2:-5])
print("-5:-2\t→", s[-5:-2])
print("-5:\t→", s[-5:])
print("  :-5\t→", s[:-5])
```
###### *output :-*
```
 2: 5   → llo
 5: 2   → 
-2:-5   → 
-5:-2   → orl
-5:     → orld!
  :-5   → Hello, W
```
___________________________________________________________


## *String useful methods*
###### *code :-*
```py
s = "   Hello, World!   "
print(s.upper())
print(s.lower())
print(s.strip()) # remove white spaces
print(s.replace('l','L'))
print(s.split(', '))
```
###### *output :-*
```
   HELLO, WORLD!   
   hello, world!   
Hello, World!
   HeLLo, WorLd!   
['   Hello', 'World!   ']
```
___________________________________________________________


## *Arithmetic Operators*
###### *code :-*
```py
a, b = 5, 2

print(f"{a} + {b}  = {a + b}")   # Addition
print(f"{a} - {b}  = {a - b}")   # Subtraction
print(f"{a} * {b}  = {a * b}")   # Multiplication
print(f"{a} / {b}  = {a / b}")   # Division
print(f"{a} % {b}  = {a % b}")   # Modulus
print(f"{a} ** {b} = {a ** b}")  # Exponentiation
print(f"{a} // {b} = {a // b}")  # Floor division
```
###### *output :-*
```
5 + 2  = 7
5 - 2  = 3
5 * 2  = 10
5 / 2  = 2.5
5 % 2  = 1
5 ** 2 = 25
5 // 2 = 2
```
___________________________________________________________


## *Assignment Operators*
```py
x = 5

x += 3  # 8
x -= 3  # 2
x *= 3  # 15
x /= 3  # 1.6666666666666667
x %= 3  # 2
x //= 3 # 1
x **= 3 # 125
x &= 3  # 1
x |= 3  # 7
x ^= 3  # 6
x >>= 3 # 0
x <<= 3 # 40
```
___________________________________________________________


## *Comparison Operators*
###### *code :-*
```py
x, y = 5, 2

print(f"{x} == {y}  → {x == y}")
print(f"{x} != {y}  → {x != y}")
print(f"{x} > {y}   → {x > y}")
print(f"{x} < {y}   → {x < y}")
print(f"{x} >= {y}  → {x >= y}")
print(f"{x} <= {y}  → {x <= y}")
```
###### *output :-*
```
5 == 2  → False
5 != 2  → True
5 > 2   → True
5 < 2   → False
5 >= 2  → True
5 <= 2  → False
```
___________________________________________________________


## *Logical Operators*
###### *code :-*
```py
x = 5

print(f"x > 3 and x < 3 → {x > 3 and x < 3}")
print(f"x > 3 or x < 3  → {x > 3 or x < 3}")
print(f"not(True)       → {not(True)}")
print(f"not(False)      → {not(False)}")
```
###### *output :-*
```
x > 3 and x < 3 → False
x > 3 or x < 3  → True
not(True)       → False
not(False)      → True
```
___________________________________________________________


## *Identity Operators*
###### *code :-*
```py
a = [1, 2, 3]
b = [1, 2, 3]
c = a

print(a is c) # returns True because z is the same object as x
print(a is not c) # returns False because z is the same object as x

print(a is b) # returns False because x is not the same object as y, even if they have the same content
print(a is not b) # returns True because x is not the same object as y, even if they have the same content

print(a == b) # to demonstrate the difference between "is" and "==": this comparison returns True because x is equal to y
print(a != b) # to demonstrate the difference between "is not" and "!=": this comparison returns False because x is equal to y
```
###### *output :-*
```
True
False
False
True
True
False
```
___________________________________________________________


## *Membership Operators*
###### *code :-*
```py
nums = [1, 2, 3]

print(1 in nums)
print(1 not in nums)

print(10 in nums)
print(10 not in nums)
```
###### *output :-*
```
True
False
False
True
```
___________________________________________________________


## *[Bitwise Operators](https://www.w3schools.com/python/python_operators.asp#:~:text=Python%20Bitwise%20Operators)*
###### *code :-*
```py
print(6 & 3) # compares each bit and set it to 1 if both are 1, otherwise 0
print(6 | 3) # compares each bit and set it to 1 if one or both is 1, otherwise 0
print(6 ^ 3) # compares each bit and set it to 1 if only one is 1, otherwise (if both are 1 or both are 0) set to 0:
print(~3) # inverts each bit (0 becomes 1 and 1 becomes 0).
print(3 << 2) # inserts the specified number of 0's (in this case 2) from the right and let the same amount of leftmost bits fall off
print(8 >> 2) # moves each bit the specified number of times to the right. Empty holes at the left are filled with 0's.
```
###### *output :-*
```
2
7
5
-4
12
2
```
___________________________________________________________


## *Operator Precedence*
| Operator | Description                                          | Associativity |
|----------|------------------------------------------------------|---------------|
| ()       | Parentheses                                          | Left to right |
| **       | Exponentiation                                       | Right to left |
| +x -x ~x | Unary plus, unary minus, and bitwise NOT             | Left to right |
| * / // % | Multiplication, division, floor division, and modulus| Left to right |
| + -      | Addition and subtraction                             | Left to right |
| << >>    | Bitwise left and right shifts                        | Left to right |
| &        | Bitwise AND                                          | Left to right |
| ^        | Bitwise XOR                                          | Left to right |
| \|       | Bitwise OR                                           | Left to right |
| == !=    | Comparisons                                          | Left to right |
| > >= < <=| Comparisons                                          | Left to right |
| is is not| Identity operators                                   | Left to right |
| in not in| Membership operators                                 | Left to right |
| not      | Logical NOT                                          | Right to left |
| and      | Logical AND                                          | Left to right |
| or       | Logical OR                                           | Left to right |
___________________________________________________________


## *Command line arguments*
###### *code :-*
```py
import sys
print("Command line arguments :- ", end="")
for i in sys.argv:
    print(i, end=", ")
print("\nlength : ", len(sys.argv))
print("type : ", type(sys.argv))
```
###### *output :-*
`>>> python Zzz.py apple grapes watermelon`
```
Command line arguments :- Zzz.py, apple, grapes, watermelon, 
length :  4
type :  <class 'list'>
```
___________________________________________________________


## *List*

[Click here to learn List in python](./list.md)

###### *As list have so many things I write it in separate file `list.md`*

___________________________________________________________

## *Tuple*

[Click here to learn Tuple in python](./tuple.md)

###### *As Tuple have so many things I write it in separate file `tuple.md`*

___________________________________________________________
## *Set*

[Click here to learn Set in python](./set.md)

###### *As Set have so many things I write it in separate file `set.md`*

___________________________________________________________


## *Dictionary*

[Click here to learn Dictionary in python](./dictionary.md)

###### *As Dictionary have so many things I write it in separate file `dictionary.md`*

___________________________________________________________


## *Conditional statements (if elif else)*
a, b = 5, 2
###### *code 1 :-*
```py
if a == b:
    print(f"{a} and {b} are equal")
elif a > b:
    print(f"{a} is grater than {b}")
else:
    print(f"{a} is less than {b}")
```
###### *output 1 :-*
```
5 is grater than 2
```
###### *code 2 :-*
```py
if a > b: print(f"{a} is grater than {b}")
```
###### *output 2 :-*
```
5 is grater than 2
```
___________________________________________________________


## *Ternary Operators*
###### *code 1 :-*
```py
print("A") if a > b else print("B")
```
###### *output 1 :-*
```
A
```
###### *code 2 :-*
```py
print("A") if a > b else print("=") if a == b else print("B")
```
###### *output 2:-*
```
A
```
___________________________________________________________


## *while loop*
###### *code :-*
```py
i = 1
while i <= 5:
  print(i, end=", ")
  i += 1
```
###### *output :-*
```
1, 2, 3, 4, 5, 
```
## *while else*
💡 with the else statement we can run a block of code once when the condition no longer is true
###### *code :-*
```py
i = 1
while i <= 5:
  print(i, end=", ")
  i += 1
else:
  print("\nLoop completed")
```
###### *output :-*
```
1, 2, 3, 4, 5, 
Loop completed
```
___________________________________________________________


## *for loop for sequence*
###### *code :-*
```py
fruits = ["apple", "kiwi", "grapes"] # it can be either a list, a tuple, a dictionary, a set, or a string
for x in fruits:
    print(x, end=", ")
```
###### *output :-*
```
apple, kiwi, grapes, 
```
## *for loop with else*
💡 with the else statement we can run a block of code once when the condition no longer is true:
###### *code :-*
```py
for x in range(6):
    print(x, end=" ")
else:
    print("Finally finished!")
```
###### *output :-*
```
0 1 2 3 4 
```
___________________________________________________________


## *for loop with range()*
```py

for x in range(5): # 💡 start from 0(by default) and end at given number but dont include last value
  print(x, end=" ") # Output : 0 1 2 3 4 
print()
for x in range(-5): # 💡 didn't give output as it start from zero and it can only go forward
  print(x, end=" ") # Output : 
print()
for x in range(2, 5): # 💡 start to end but dont include end value
  print(x, end=" ") # Output : 2 3 4 
print()
for x in range(-2, -5): # 💡 didn't give output as it start from -2 and it can only go forward
  print(x, end=" ") # Output : 
print()
for x in range(-3, 3):
  print(x, end=" ") # Output : -3 -2 -1 0 1 2 
print()
for x in range(3, -3): # 💡 same here didn't give output as it start from 3 and it can only go forward
  print(x, end=" ") # Output : 
print()
for x in range(-6, 8, 2): # 💡 increment by 2 (even numbers)
  print(x, end=" ") # Output : -6 -4 -2 0 2 4 6 
print()
for x in range(-5, 7, 2): # 💡 increment by 2 (odd numbers)
  print(x, end=" ") # Output : -5 -3 -1 1 3 5
print()
for x in range(-2,-5,-1): # 💡 decrement by -1 so we can move backwards instead of forward.
  print(x, end=" ") # Output : -2 -3 -4 
print()
for x in range(4,-8,-2): # 💡 decrement by -2 
  print(x, end=" ") # Output : 4 2 0 -2 -4 -6 
```
___________________________________________________________


## *function*
###### *code :-*
```py
def sayHello():
   print("Hellllooooo!")

sayHello()
```
###### *output :-*
```
Hellllooooo!
```
## *function with parameter*
###### *code :-*
```py
def sayHello(name):
   print(f"Hello, {name}!")

def division(a, b):
    return a / b

sayHello("Jay")
# sayHello()  👾 ERROR : TypeError
# sayHello("Jay", "Parmar")  👾 ERROR : TypeError
print(division(5, 2))
```
###### *output :-*
```
Hello, Jay!
2.5
```
___________________________________________________________


## *function Arbitrary arguments, *args*
###### *code :-*
```py
def sum(*values):
    sum = 0
    for i in values:
        sum += i
    return sum

print(sum())
print(sum(2))
print(sum(2, 5))
```
###### *output :-*
```
0
2
7
```

## *function Keyword arguments*
###### *code :-*
```py
def greet(message, name):
    print(f"{message}, {name}!")

greet(name="Jay", message="Hello")
```
###### *output :-*
```
Hello, Jay!
```

## *function Arbitrary Keyword arguments*
###### *code :-*
```py
def my_func(**details):
	for i in details:
		print(f"{i} : {details[i]}")
my_func(name="Jay", age=18)
```
###### *output :-*
```
name : Jay
age : 18
```

## *function Default argument*
###### *code :-*
```py
def greet(name, message="Hello"):
    print(f"{message}, {name}!")

greet(name="Jay")

greet(name="Elon", message="Hi")
```
###### *output :-*
```
Hello, Jay!
Hi, Elon!
```
___________________________________________________________


## *Lambda function*
💡 A lambda function is a small anonymous function that can take any number of arguments, but can only have one expression.
###### *code :-*
```py
square = lambda x: x**2

result = square(5)
print(result)
```
###### *output :-*
```
25
```
___________________________________________________________

<!-- 
## *title*
###### *code :-*
```py

```
###### *output :-*
```

```
___________________________________________________________ 
-->


# ***Remaining notes coming soon (may be ¯\\_(ツ)_/¯) ...***