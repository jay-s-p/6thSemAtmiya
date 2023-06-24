#### 1.2 Write a program to check entered values prime or not.

<br>

```py
n = int(input("Enter no. : "))
if n <= 0:
    exit("Invalid input")
elif n == 1:
    exit("1 is not Prime")

isPrime = True

i = 2
while i < n:
    if n % i == 0:
        isPrime = False
        break
    i += 1

if isPrime:
    print(n, "is prime.")
else:
    print(n, "is not prime.")
```


<br>

##### *Output* :-

```
Enter no. : 7
7 is prime.
```

```
Enter no. : 9
9 is not prime.
```

```
Enter no. : -6
Invalid input
```
