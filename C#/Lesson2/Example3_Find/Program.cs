﻿int[] array = { 1, 2, 3, 4, 5, 6, 4, 8 };

int n = array.Length;
int find = 8;

int index = 0;

while(index < n)
{
    if (array[index] == find) Console.WriteLine(index);
    index++;
}