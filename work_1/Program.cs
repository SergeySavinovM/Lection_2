int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result ) result = arg2;
    if(arg3 > result ) result = arg3;
    return result;
}

int num1 = 13;
int num2 = 25;
int num3 = 9;
int num4 = 73;
int num5 = 16;
int num6 = 27;
int num7 = 3;
int num8 = 74;
int num9 = 30;

int max = Max(Max(num1, num2, num3),Max(num4, num5, num6),Max(num7, num8, num9));

Console.WriteLine(max);