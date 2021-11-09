#include <stdio.h>

typedef int(*Calc)(int a, int b);

int Add(int a, int b)
{
	int result = a + b;
	return result;
}
int Sub(int a, int b)
{
	int result = a - b;
	return result;
}




int main(void)
{
	int x = 100;
	int y = 200;

	Calc funcPoint1 = &Add;
	Calc funcPoint2 = &Sub;

	int z1 = Add(x, y);//直接调用
	int z2 = Sub(x, y);

	int z3 = funcPoint1(x, y);//间接调用，效果完全一致
	int z4 = funcPoint2(x, y);

	printf("%d+%d=%d\n", x, y, z1);
	printf("%d-%d=%d\n", x, y, z2);
	printf("%d+%d=%d\n", x, y, z3);
	printf("%d-%d=%d\n", x, y, z4);
	return 0;
}

