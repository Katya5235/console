// Нахождение максимума из 9 числел

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a = 56;
int b = 89;
int c = 101;

int d = 98;
int i = 77;
int f = 4;

int k = 6;
int l = 9;
int r = 66;

int max1 = Max(a, b, c);
int max2 = Max(d, i, f);
int max3 = Max(k, l, r);
int max = Max(max1, max2, max3);

Console.WriteLine(max);