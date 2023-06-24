/*
Draw the diagram of the seven segment interfacing with the ATmega32 and
write program to display 9 on the seven segment display.
*/

#include <avr/io.h>

int main(void)
{
    DDRC = 0xFF;
    while (1)
        PORTC = 0x6F;

    return 0;
}

/*
    0x3F  // 0
    0x06  // 1
    0x5B  // 2
    0x4F  // 3
    0x66  // 4
    0x6D  // 5
    0x7D  // 6
    0x07  // 7
    0x7F  // 8
    0x6F  // 9
*/