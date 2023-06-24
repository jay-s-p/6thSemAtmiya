/*
Write an AVR C Program to take input from PORTB. Perform logical X-OR
operation between given input value and 0xAA. Give the answer to PORTA.
*/

#include <avr/io.h>

int main(void)
{
    DDRB = 0x00;
    DDRA = 0xFF;
    while(1)
        PORTA = PINB ^ 0xAA;
        
    return 0;
}