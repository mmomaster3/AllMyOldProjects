//------------------------------------------------------------------------
#include <iostream>
#include <math.h>
#include <string>
#include <conio.h>
#include <stdio.h>
using namespace std;
//------------------------------------------------------------------------

int main()
{
	double m, k, n;
	double f_x, x, z, y;
	int choose;
	//string F_X;
	puts("Input m:");
	scanf("%lf", &m);
	puts("Input k:");
	scanf("%lf", &k);
	puts("Input n:");
	scanf("%lf", &n);
	puts("\nChoose f(x): 1 - (2*x), 2 - (x^2), 3 - (x/3) :");
	scanf("%d", &choose);
	puts("\nInput z:");
	scanf("%lf", &z);
	if (z > 1)
		x = z;
	else
		x = pow(z, 2) + 1;
	switch (choose) {
	case 1:
		f_x = 2 * x;
		break;
	case 2:
		f_x = x*x;
		break;
	case 3:
		f_x = x / 3.0;
		break;
	default:
		break;
	}
	y = sin(n*f_x) + cos(k*x) + log(m * x);

	//y = (a*log(1 + pow(x, 0.2))) + (pow(cos(f_x + 1), 2));
	//cout << "\nM = " << m << " k = " << k << " n = " << n << " z = " << z << "f(x) = " << F_X << " x = " << x;
	//cout << "\ny = " << y;
	//printf("f(x) = %s, m = %10.3f, k = %f, n = %f, z = %f, x = %f", F_X, m, k, n, z, x);
	printf("y = %f", y);

	getch();
	return 0;
}