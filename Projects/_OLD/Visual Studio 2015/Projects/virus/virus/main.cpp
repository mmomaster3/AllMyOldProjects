#include <Windows.h>
#include <stdio.h>

int main()
{
	int ch;
	FreeConsole();
	while (1)
	{
		ch = getchar();
		if (ch != 'p')
		{
			BlockInput(true);
			
		}
		else
		{
			continue;
			break;
		}

	}
}