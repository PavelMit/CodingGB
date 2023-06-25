// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных элементов массива.

/*
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

int GetNegativeSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) 
            sum += array[i];
    }
    return sum;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreatRandomArray(size, min, max);
int sum = GetNegativeSum(newArray);
ShowArray(newArray);
Console.WriteLine($"Sum of negative number of new array is% {sum}");

*/

// 1. Напишите программу заменs элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.

/*
int[] ChangePosAndNeg(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] *= -1;
    return array;
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

int[] newArray = CreatRandomArray(12, -9, 9);
ShowArray(newArray);
ShowArray(ChangePosAndNeg(newArray));
*/

// 2. Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

/*

bool FindNumberInArray(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
        if (array[i] == number)
            return true;
    return false;
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

Console.WriteLine("")

*/

// 3. Задайте одномерный массив из m случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

/*
int HowManyNumbers(int[] array, int a, int b)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= a && array[i] <= b) counter++;
    return counter;
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
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input an minimum requested number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max requested number: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreatRandomArray(size, min, max);
ShowArray(newArray);
int number = HowManyNumbers(newArray, a, b);
Console.WriteLine($"In new array there are {number} requested number between {a} and {b}");

*/

