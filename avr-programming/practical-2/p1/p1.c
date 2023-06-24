/*
Write an AVR C Program to give the value from 0 to 9 on PORTB.
*/

#include <avr/io.h>

int main(void)
{
	DDRB = 0xFF;
	unsigned char i;
	for (i = 0; i <= 9; i++)
		PORTB = i;
	return 0;
}