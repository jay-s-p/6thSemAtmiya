/*
8.1 Write an AVR C Program to display “HELLO” in 16x2 LCD. Assume Data
lines of LCD are connected to PORTB and RS, RW and EN are connected to PD0, PD1
and PD2 respectively.
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
		lcd_print("Hello");
		_delay_ms(1000);
		command(0X01); // Clearing the display.
		_delay_ms(1000);
	}
	return 0;
}