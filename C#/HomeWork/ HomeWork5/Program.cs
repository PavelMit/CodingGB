/*Task 1.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
int EvenNumberedInArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) result++;
    return result;
}

int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreatRandomArray(size, 100, 999);
ShowArray(newArray);
int number = EvenNumberedInArray(newArray);
Console.WriteLine($"In new array there are {number} even-numbered numbers");
*/

/*
Task 2.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0
*/

/*
int SumOfUnevenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) sum += array[i];
    return sum;
}

int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreatRandomArray(size, min, max);
ShowArray(newArray);
int sum = SumOfUnevenNumbers(newArray);
Console.WriteLine($"The sum of number with uneven index in the new array is: {sum} ");
*/


/*
Task 3.Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

/*
int DiffMaxAndMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    
    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreatRandomArray(size, min, max);
ShowArray(newArray);
int diff = DiffMaxAndMin(newArray);
Console.WriteLine($"The difference between the max and the min numbers in the new array is: {diff} ");
*/