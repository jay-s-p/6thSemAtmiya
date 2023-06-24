
#### *1. Write an AVR C program to get a byte of data from Port A and send it to Port B.*


|[◀️ Prv](../../practical-2/p5/readme.md)|[🏠 Home](/README.md)|[Next ▶️](../p2/readme.md)|
|---|---|---|

```c
#include <avr/io.h>

int main(void)
{

	DDRA = 0x00;
	DDRB = 0xFF;
	PORTA = 0xFF;
	while (1)
		PORTB = PINA;
	return 0;
}
```
<img src="./p1.png" style="width:30em" title="output-1" alt="output-1" >

<img src="./p1-proteus.png" style="width:60em" title="output-1" alt="output-1" >
