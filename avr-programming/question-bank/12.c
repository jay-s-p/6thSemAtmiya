/*
Draw interfacing diagram of LEDs (8 LEDs) connected with the port B of
ATmega32. Write program to Turn ON LEDs, if input at port A is positive
otherwise turn OFF LEDs.
*/


#include <avr/io.h>

int main(void)
{
    DDRA = 0x00;
    DDRB = 0xFF;
    while(1)
    {
        if (PINA < 128)
            PORTB = 0xFF;
        else
            PORTB = 0x00;
    }
    
    return 0;
}