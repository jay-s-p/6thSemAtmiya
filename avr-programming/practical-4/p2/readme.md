
#### *2. Write an AVR C Program to take input from PORTA. Perform logical OR operation between given input value and 0xAA. Give the answer to PORTD.*


|[◀️ Prv](../p1/readme.md)|[🏠 Home](/README.md)|[Next ▶️](../p3/readme.md)|
|---|---|---|

```c
#include <avr/io.h>

int main(void)
{
	DDRA = 0x00;
	DDRD = 0xFF;
	while (1)
		PORTD = PINA | 0xAA;
	return 0;
}
```
<img src="./p2.png" style="width:30em" title="output-1" alt="output-1" >
