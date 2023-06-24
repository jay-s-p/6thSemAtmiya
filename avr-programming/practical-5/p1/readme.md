
#### *1. Write an AVR C program to continuously toggle only bit 4 of PORTB.*


|[◀️ Prv](../../practical-4/p5/readme.md)|[🏠 Home](/README.md)|[Next ▶️](../p2/readme.md)|
|---|---|---|

```c
#include <avr/io.h>
#include <util/delay.h>

int main(void)
{
    DDRB = DDRB | 0b00010000;
    while (1)
    {
        PORTB = PORTB | 0b00010000;
        _delay_ms(200);
        PORTB = PORTB & 0b11101111;
        _delay_ms(200);
    }
    return 0;
}
```
<img src="./p1-1.png" style="width:30em" title="output-1" alt="output-1" >

<img src="./p1-2.png" style="width:30em" title="output-2" alt="output-2" >
