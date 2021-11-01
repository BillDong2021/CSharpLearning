#include <iostream>
#include "Student.h"

int main()
{
	Student* pStu = new Student();
	double x = 3.0;
	double y = 5.0;
	double result = pStu->Add(x, y);
	std::cout << x << "+" << y << "=" << result;
	return 0;
}
