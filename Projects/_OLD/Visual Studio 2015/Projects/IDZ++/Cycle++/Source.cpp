#include <conio.h>
#include <stdio.h>
#include <math.h>

void main() {
	double a, b, x, h, y, raz, s, pi = 3.1415926;;
	int n, k;
	double fact = 1.;
	puts("Input a,b,h,n");
	scanf("%lf%lf%lf%d", &a, &b, &h, &n);
	for (x = a; x <= b; x += h) {
		s = 1;
		fact = 1;
		for (k = 1; k <= n; k++) {
			fact *= 2 * k;

			s += pow(-1, (double)k) * (pow(2.0*x, 2.0 *k) / fact);
		}
		y =2.0 * (pow(cos(x - 1), 2));
		raz = y - s;
		printf("\n x= %8.2lf summa X= %18.15lf funkciya Y= %18.15lf Raznost'|Y-X|= %18.15lf", x, s, y, raz);
	}
	puts("\nPress any key ... ");
	getch();
}