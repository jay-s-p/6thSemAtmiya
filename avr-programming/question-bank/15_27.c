/*
15 & 27. Write a C program to send values 0x55 and 0xAA continuously on port c of ATmega32 with delay of 70µs. Use timer0, Normal mode and no prescaler options to generate delay.
*/

#include <avr/io.h>

void T0delay();

int main(void)
{
    DDRB = 0xFF;
    while (1)
    {
        PORTB = 0x55;
        T0delay();
        PORTB = 0xAA;
        T0delay();
    }
    return 0;
}

void T0delay()
{
    TCNT0 = 0x20;
    TCCR0 = 0x01;
    while ((TIFR & 0x01) == 0);
    TCCR0 = 0;
    TIFR = 0x01;
}
