
#### *3. Write an AVR C Program to take the value from Port B if the value is less than 100 give it to Port C otherwise to port D.*


|[◀️ Prv](../p2/readme.md)|[🏠 Home](/README.md)|[Next ▶️](../p4/readme.md)|
|---|---|---|

```c
#include <avr/io.h>

int main(void)
{
	DDRB = 0x00;
	DDRC = 0xFF;
	DDRD = 0xFF;

	while (1)
		if (PINB < 100)
			PORTC = PINB;
		else
			PORTD = PINB;

	return 0;
}
```
<img src="./p3-1.png" style="width:30em" title="output-1" alt="output-1" >

<img src="./p3-2.png" style="width:30em" title="output-2" alt="output-2" >
