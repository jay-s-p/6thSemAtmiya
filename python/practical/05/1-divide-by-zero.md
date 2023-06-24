#### 5.1 Handle divide by zero exception.

<br>

```py
try:
    x = int(input("Enter first  no. : "))
    y = int(input("Enter second no. : "))
    z = x / y
except ZeroDivisionError:
    print("Division by zero error!")
except:
    print("An error occurred!")
else:
    print(x, "/", y, "=", z)
```

<br>

##### *Output* :-

```
Enter first  no. : 10
Enter second no. : 0
Division by zero error!
```


```
Enter first  no. : 10
Enter second no. : 5
10 / 5 = 2.0
```

```
Enter first  no. : abcd
An error occurred!
```
