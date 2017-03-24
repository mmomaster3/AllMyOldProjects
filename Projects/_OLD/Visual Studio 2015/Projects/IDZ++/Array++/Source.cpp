#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include<conio.h>

#define SIZE 10

int main()
{
	int i = 0;
	int sum = 0;
	int s = 0;
	int values[SIZE];
	puts("1 - Random, 2 - Vvod s kvaviaturi");
	scanf("%d", &s);
	if (s == 1) {
		for (i = 0; i < SIZE; ++i)
			values[i] = rand() % 9 - rand() % 9;
	}
	else {
		for (i = 0; i < SIZE; i++)
		{
			printf("Vvod elementa %d: ", i);
			scanf("%d", &values[i]);
		}
	}


	for (i = 0; i < SIZE && values[i] > 0; ++i);
	for (i = i + 1; i < SIZE; ++i)
		sum += abs(values[i]);

	for (i = 0; i < SIZE; ++i)
		printf("%d ", values[i]);
	printf("\nsum: %d\n", sum);

	puts("\nPress any key ... ");
	getch();
	return 0;
}