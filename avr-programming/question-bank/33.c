/*
Write a program to monitor the status of PA7 pin of AVR controller. If PA7
is 1 DC motor controlled through the PB0 bit should move with 25% duty
cycle else DC motor should move with 50% duty cycle.
*/


#include <avr/io.h>
#include <util/delay.h>

#define SW (PORTA & (1<<7))
#define F_CPU 8000000UL

int main(void) {
    DDRA = 0x7F;
    DDRB = 0x01;

    while (1)
    {
        if(SW == 1)
        {
            PORTB = PORTB | (1 << 0);
            _delay_ms(75);
            PORTB = PORTB & (~(1 << 0));
            _delay_ms(25);
        }
        else
        {
            PORTB = PORTB | (1 << 0);
            _delay_ms(50);
            PORTB = PORTB & (~(1 << 0));
            _delay_ms(50);
        }
    }
    
    return 0;
}

