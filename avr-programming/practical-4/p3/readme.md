
#### *3. Write an AVR C Program to compliment the PORTB with delay of 100ms continuously.*


|[◀️ Prv](../p2/readme.md)|[🏠 Home](/README.md)|[Next ▶️](../p4/readme.md)|
|---|---|---|

```c
#include <avr/io.h>
#include <util/delay.h>

int main(void)
{
    DDRB = 0xFF;
    while (1)
    {
        PORTB = ~PORTB;
        _delay_ms(100);
    }
    return 0;
}
```
<img src="./p3-1.png" style="width:30em" title="output-1" alt="output-1" >

<img src="./p3-2.png" style="width:30em" title="output-2" alt="output-2" >
