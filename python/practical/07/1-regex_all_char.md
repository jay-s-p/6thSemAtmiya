#### 7. Write following programs using regular expressions (All character):-

<br>

```py
import re

str = "He1lo W0rld"
x = re.findall('\D+', str)
print(x)
```

<br>

##### *Output* :-

```
['He', 'lo W', 'rld']
```
