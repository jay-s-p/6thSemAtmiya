"""
7. Write following programs using regular expressions:-
    7.1  All character:-
"""

import re

str = "He1lo W0rld"
x = re.findall('\D+', str)
print(x)

""" O/P :-
['He', 'lo W', 'rld']
"""
