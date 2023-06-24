/*
8.2 Write a Program to display “ATMIYA” in first line and your name on second
line of 16x2 LCD in center. Assume the same connections as above.
*/

#include <avr/io.h>
#include <stdio.h>
#include <util/delay.h>
#define F_CPU 16000000UL

void command(unsigned char cmd)
{
	PORTC = 0X02;
	PORTD = cmd;
	PORTC = 0X00;
	_delay_ms(15);
}

void lcd_data(unsigned char data)
{
	PORTC = 0X03;
	PORTD = data;
	PORTC = 0X01;
	_delay_ms(15);
}

void lcd_print(char *p)
{
	while (*p)
	{
		lcd_data(*p++);
	}
}

int main(void)
{
	DDRC = 0XFF;   // This register is used for selecting the R/S and R/W pin.
	DDRD = 0XFF;   // This register is used to give the data or commands.
	command(0x38); // Activated 2 lines in 8-bit mode.
	command(0X0F); // Display is ON, cursor is blinking.
	command(0x01); // Clearing the display.
	while (1)
	{
		command(0X80); // Forced the cursor to first position of first line.
		lcd_print("ATMIYA");
		_delay_ms(1000);
		command(0XC0); // Forced the cursor to the first position of second line.
		lcd_print("JAY");
		_delay_ms(1000);
		command(0X01); // Clearing the display.
		_delay_ms(1000);
	}
	return 0;
}