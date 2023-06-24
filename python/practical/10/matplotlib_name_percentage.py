#### 10. Plot graph of result of student (Name vs. Percentage) using Pylab.
import matplotlib.pyplot as plt

# x-coordinates of left sides of bars
left = [1, 2, 3,]

# heights of bars
height = [80, 24, 50,]

# labels for bars
tick_label = ['Sanjay', 'Vijay', 'Rajesh',]

# plotting a bar chart
plt.bar(left, height, tick_label = tick_label,
width = 0.8, color = ['red', 'green'])

# naming the x-axis
plt.xlabel('Student Name')

# naming the y-axis
plt.ylabel('Marks')

# plot title
plt.title('Maths Result')

# function to show the plot
plt.show()