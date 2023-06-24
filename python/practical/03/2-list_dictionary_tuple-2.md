#### 3.2 Write a program to learn different types of structures (list, dictionary, tuple) in python. Display all information of student.

<br>

```py
# Define a list to store student information
students = []

# Add a new student
name = 'Alice'
age = 20
grades = (90, 85, 88)
student = {
    'name': name,
    'age': age,
    'grades': grades
}
students.append(student)

# Add another student
name = 'Bob'
age = 21
grades = (95, 80, 82)
student = {
    'name': name,
    'age': age,
    'grades': grades
}
students.append(student)

# Display all students
for student in students:
    print('Name:', student['name'])
    print('Age:', student['age'])
    print('Grades:', student['grades'])
    print()
```

<br>

##### *Output* :-

```
Name: Alice
Age: 20
Grades: (90, 85, 88)

Name: Bob
Age: 21
Grades: (95, 80, 82)
```

<br>

<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;This program creates a list called students to store the information of each student. Each student is represented as a dictionary with keys for name, age, and grades.
The grades are stored as a tuple. The program then adds two students to the list and displays their information using a for loop.</p>


