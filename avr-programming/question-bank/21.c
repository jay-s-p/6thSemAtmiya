/*
21. Write a program to read ATmega32 ADC Using Polling Method in C.
*/

#include <avr/io.h>

int main(void) {
    DDRB = 0xFF;
    DDRD = 0xFF;
    DDRA = 0;
    ADCSRA = 0x87;
    ADMUX = 0xC0;

    while (1)
    {
        ADCSRA |= (1 << ADSC);
        while ((ADCSRA & (1<<ADIF)) == 0);
        PORTD = ADCL;
        PORTB = ADCH;
    }
    
    return 0;
}
