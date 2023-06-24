
#### *5. Write an AVR C Program to send the ASCII value of your name on Port B.*


|[◀️ Prv](../p4/readme.md)|[🏠 Home](/README.md)|[Next ▶️](../../practical-4/p1/readme.md)|
|---|---|---|

```c
#include <avr/io.h>

int main(void)
{
    DDRB = 0xFF;
    unsigned char i;
    unsigned char arr[] = "jayparmar";
    for (i = 0; i < sizeof(arr)/sizeof(arr[0]); i++)
        PORTB = arr[i];
    return 0;
}
```
<img src="./p5.png" style="width:30em" title="output-1" alt="output-1" >
