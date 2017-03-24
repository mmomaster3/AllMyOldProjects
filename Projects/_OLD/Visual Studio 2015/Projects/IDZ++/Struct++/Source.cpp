#include<iostream>
using namespace std;

struct Baze
{
	char name[15];
	int ball[5];
	int itog;
};

int main()
{
	int n, average;
	puts("Enter the number of students... ");
	scanf("%d",&n);
	puts("\nEnter average balls... ");
	scanf("%d", &average);
	puts("\n");
	Baze *baze = new Baze[n];
	for (int i = 0; i < n; i++)
	{
		puts("Input name student... "); 
		scanf("%s", &baze[i].name);
		puts("input balls... ");
		for (int j = 0; j < 5; j++)
		{
			scanf("%d", &baze[i].ball[j]);
			puts(" ");

		}
		baze[i].itog = 0;

	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			baze[i].itog += baze[i].ball[j];

		}
		if (((baze[i].itog) / 5.) > average) { printf("Name student: %s > %d", baze[i].name, average); }
	}
	system("\npause");
	return 0;
}