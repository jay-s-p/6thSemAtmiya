
#### *4. Write an AVR C Program to compliment Port C 200 times. (Note: Only show output of two values)*

|[◀️ Prv](../p3/readme.md)|[🏠 Home](/README.md)|[Next ▶️](../p5/readme.md)|
|---|---|---|

```c
#include <avr/io.h>

int main(void)
{
    DDRC = 0xFF;
    unsigned char i;
    for (i = 0; i < 200; i++)
        PORTC = ~PORTC;
    return 0;
}
```
<img src="./p4-1.png" style="width:30em" title="output-1" alt="output-1" >

<img src="./p4-2.png" style="width:30em" title="output-2" alt="output-2" >
