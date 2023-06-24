/*
7.1 Write an AVR C program to display any single digit between 0 to 9 on 
7-segment display.
*/ 

#include <avr/io.h>

int main(void)
{
	DDRC = 0xFF;
    while(1)
        PORTC = 0x5B;
	return 0;
}