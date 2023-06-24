/*
Write an AVR C Program to give the value from 00 to AA on PORTC.
*/

#include <avr/io.h>

int main(void)
{
	DDRC = 0xFF;
	unsigned char i;
	for (i = 0; i <= 170; i++)
		PORTC = i;
	return 0;
}