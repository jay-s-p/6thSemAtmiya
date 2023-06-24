"""
 13. Draw graphics Smiley using Turtle.
"""
import turtle

pen = turtle.Turtle()


# function for creation of eye
def eye(col, rad):
    pen.down()
    pen.fillcolor(col)
    pen.begin_fill()
    pen.circle(rad)
    pen.end_fill()
    pen.up()

# draw face
pen.fillcolor('yellow')
pen.begin_fill()
pen.circle(100)
pen.end_fill()
pen.up()
# draw eyes
pen.goto(-40, 120)
eye('white', 15)
pen.goto(40, 120)
eye('white', 15)
# draw mouth
pen.goto(-40, 85)
pen.down()
pen.right(90)
pen.circle(40, 180)
pen.up()
pen.end_fill()
pen.hideturtle()
turtle.done()