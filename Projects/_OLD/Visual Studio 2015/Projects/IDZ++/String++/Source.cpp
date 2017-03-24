#include <string.h>
#include <stdio.h>
#include <conio.h>

void main()
{
	char str[20] = " this is Sparta!", str1[30] = { 0 }, str2[30] = { 0 };
	int k;

	puts("Vvedite k:");
	scanf("%d", &k);

	while (str[k] != ' ') k -= 1;

	strncpy(str1, str, k);
	strcpy(str2, str + k);

	printf("%s", str1);
	printf("\n%s", str2);

	puts("\nPress any key ... ");
	getch();
}