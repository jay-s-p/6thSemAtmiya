
#### *1. Write an AVR C Program to take input value from PORTB. Multiply this content by 2 and give it to PORTD.*


|[◀️ Prv](../../practical-3/p5/readme.md)|[🏠 Home](/README.md)|[Next ▶️](../p2/readme.md)|
|---|---|---|

```c
#include <avr/io.h>

int main(void)
{
    DDRB = 0x00;
    DDRD = 0xFF;
    while (1)
        PORTD = PINB * 2;
    return 0;
}
```
<img src="./p1.png" style="width:30em" title="output-1" alt="output-1" >
