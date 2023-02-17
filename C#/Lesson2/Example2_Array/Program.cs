int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 111, 4452, 4123, 1141, 535, 163, 127, 844, 91 };

array[0] = 12;
Console.WriteLine(array[4]);

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
// int max = Max(Max(a1, a2, a3), Max(a4, a5, a6), Max(a7, a8, a9));

Console.WriteLine(max);