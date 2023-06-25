/*
Task 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
double PowerOfNumber(double number, int power)
{
    double result = 1;
    for (int i = 0; i < power; i++) result = result * number;
    return result;
}

Console.Write("Input a number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a power: ");
int power = Convert.ToInt32(Console.ReadLine());
double result = PowerOfNumber(number, power);
Console.WriteLine($"The {power} power of the number {number} is {result}");
*/

/*
Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int SumOfDigits(int number)
{
    int result = 0;
    while (number != 0)
    {
        result = result + number % 10;
        number /= 10;
    }
    return result;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigits(number);
Console.WriteLine($"The sum of digits of the {number} is {result}");
*/

/*
Task3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*

int[] MakeArray(int number)
{
    int[] array = new int[number];
    for(int i = 0; i < number; i++)
    {
        Console.Write($"Please input {i+1} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("How many elements do you want to input in array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayNew = MakeArray(size);
Console.Write("Your array looks like: ");
ShowArray(arrayNew);

*/

