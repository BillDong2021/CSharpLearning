#include <stdio.h>

double Add(double a, double b)
{
	return a + b;
}

int main()
{
	double x = 3.0;
	double y = 4.0;
	double result = Add(x, y);
	printf("%f+%f=%f", x, y, result);
	return 0;
}