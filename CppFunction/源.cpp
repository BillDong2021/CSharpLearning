#include <iostream>

double Add(double a, double b)
{
	return a + b;
}

int main()
{
	double x = 3.0;
	double y = 5.0;
	double result = Add(x, y);
	std::cout << x << "+" << y << "=" << result;
	return 0;
}