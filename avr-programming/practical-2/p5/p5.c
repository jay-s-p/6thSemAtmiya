/*
Write an AVR C Program to compliment Port C 10000 times. (Note: Only show output of two values)
*/

#include <avr/io.h>

int main(void)
{
    DDRC = 0xFF;
    unsigned int i;
    for (i = 0; i < 10000; i++)
        PORTC = ~PORTC;
    return 0;
}