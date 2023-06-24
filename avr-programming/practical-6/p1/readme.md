
#### *1. Write an AVR C Program to generate the LED pattern as following continuously. Only LED on D0 position is ON and rest of all OFF, D1 is ON and others are OFF and so on.*

|[◀️ Prv](../../practical-5/p5/readme.md)|[🏠 Home](/README.md)|[Next ▶️](../p2/readme.md)|
|---|---|---|

<br />

```c
#include <avr/io.h>
#include <util/delay.h>

int main(void)
{
	DDRC = 0xFF;
	unsigned char i;
	while (1)
		for (i = 0; i < 8; i++)
		{
			PORTC = (1 << i);
			_delay_ms(200);
		}
	return 0;
}
```
<img src="./p1.png" style="width:30em" title="output-1" alt="output-1" >

<img src="./p1-proteus.png" style="width:60em" title="output-1" alt="output-1" >
