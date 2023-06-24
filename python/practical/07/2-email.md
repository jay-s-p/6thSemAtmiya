#### 7.2 Regular expression for email like. [a-z].[az]@[a-z].domainname ("@" not be repeated and last "." not repeated). Extract email from text.

<br>

```py 
import re

txt = 'My emails are a.b@mail.com and c.d@mail.com'
my_email = re.findall('[\w\.-]+@[\w\.-]+', txt)
print(my_email)
```

<br>

##### *Output* :-

```
['a.b@mail.com', 'c.d@mail.com']
```