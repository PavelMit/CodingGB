
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int GetSum(int number)
{
    int sum = 0;
    for (int current = 1; current <= number; current++) sum += current;
    return sum;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = GetSum(number);
Console.WriteLine($"Sum of numbers from 1 to {number} is {result}");
*/


//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int GetDigit(int number)
{
    int digit = 0;
    if (number == 0) digit = 1;
    while (number != 0)
    {
        number = number / 10;
        digit++;
    }
    return digit;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = GetDigit(num);
Console.WriteLine($"Count of digits in number {num} is {digit}");
*/

/*
int GetFactorial(int number)
{
    int factorial = 1;
    for (int current = 2; current <= number; current++) factorial *= current;
    return factorial;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = GetFactorial(number);
Console.WriteLine($"Factorial of number {number} is {result}");
*/

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

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreatRandomArray(size, min, max);
ShowArray(newArray);
*/

