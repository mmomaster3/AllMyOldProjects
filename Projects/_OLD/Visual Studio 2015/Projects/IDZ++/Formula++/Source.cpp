#include <conio.h>
#include <stdio.h>
#include <math.h>

void main()
{
	double x = 17.421, y = 10.365 * pow(10, -3), z = 0.828 * pow(10, 5);
	double f;

	f = (pow((y + pow(x - 1, 1. / 3.)), 1. / 4.)) / ((x - y) * (pow(sin(z), 2) + tan(z)));

	printf("f= %lf", f);

	puts("\nPress any key ... ");
	getchar();
}