/*
Write an AVR C Program to continuously give 0xF0 and 0x0F to PORTB.
There should be delay of 500ms between each value.
*/

#include <avr/io.h>
#include <util/delay.h>

int main(void)
{
    DDRB = 0xFF;
    while(1)
    {
        PORTB = 0xF0;
        _delay_ms(500);
        PORTB = 0x0F;
        _delay_ms(500);
    }
    
    return 0;
}