/*
Write an AVR C Program to send the ASCII value of word “ATMIYA” on Port C.
*/

#include <avr/io.h>

int main(void)
{
	DDRC = 0xFF;
	unsigned char i, arr[] = "ATMIYA";
	for (i = 0; i < 6; i++)
		PORTC = arr[i];
	return 0;
}