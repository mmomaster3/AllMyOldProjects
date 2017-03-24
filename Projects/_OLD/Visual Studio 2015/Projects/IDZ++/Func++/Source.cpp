#include <conio.h>
#include <stdio.h>
#include <math.h>

typedef double(*TFunc)(double);


double func1(double x){
	int n = 13;
	double s = 1;
	double fact = 1.;
	for (int k = 1; k <= n; k++) {
		fact *= 2 * k;

		s += pow(-1, (double)k) * (pow(2.0 * x, 2.0 * k) / fact);
	}
	return s;
}

double func2(double x) {
	return 2 * (pow(cos(x - 1), 2));
}

void Out_Rez(TFunc f, double a, double b, double h) {
	double x, raz;
	for (x = a; x <= b; x += h) {
		printf("\n x= %8.2lf F= %18.15lf", x, f(x));
	}
}

void main() {
	double a, b, h;
	puts("Input a,b,h");
	scanf("%lf%lf%lf", &a, &b, &h);
	
	puts("\n\tS= ");
	Out_Rez(func1, a, b, h);
	puts("\n___________________________________________________________________________");
	puts("\n\tY= ");
	Out_Rez(func2, a, b, h);

	puts("\nPress any key ... ");
	getch();
}