"""
15. Write a program to create push buttons using tkinter. Background color
of a frame should be changed when buttons are clicked.
"""
from tkinter import *

gui = Tk(className='Python Examples - Window Color')
gui.geometry("400x200")
#set window color
bg_clr = "white"
gui.configure(bg=bg_clr)

def change_clr_blue():
    bg_clr = "blue"
    gui.configure(bg=bg_clr)


def change_clr_red():
    bg_clr = "red"
    gui.configure(bg=bg_clr)


def change_clr_green():
    bg_clr = "green"
    gui.configure(bg=bg_clr)


btn = Button(gui, text="click me to make background color to blue", fg='blue', command=change_clr_blue).pack()
btn = Button(gui, text="click me to make background color to red", fg='red', command=change_clr_red).pack()
btn = Button(gui, text="click me to make background color to green", fg='green', command=change_clr_green).pack()

gui.mainloop()