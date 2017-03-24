#include <math.h>
#include <stdio.h>
#include <conio.h>


int main() {
	puts("Vvedite razmer massiva");
	int N;
	scanf("%d", &N);
	int **a = new int*[N];
	for (int count = 0; count < N; count++)
		a[count] = new int[N];

	for (int i = 0; i < N; i++)
		for (int j = 0; j < N; j++) {
			printf("a[%i][%i[=", i, j);
			scanf("%i", &a[i][j]);
		}

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++)
			printf(" %d", a[i][j]);
		printf("\n");
	}

	int max = a[0][0];
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			if (i > (N - j - 1))
				if (a[i][j] > max)
					max = a[i][j];
		}
	}
	printf("sum: %d", max);


	delete[] a;
	puts("\nPress any key ... ");
	getch();
}