// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;
    int result = hundreds * 10 + units; 

    return (result);
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

/*
bool IsMultipled(int num, int div1, int div2)
{
    if(num % div1 * div2 == 0)
        return true;
    else
        return false;
}

bool IsMultipledBest(int num, int div1, int div2)
{
    return num % div1 == 0 && num % div2 == 0;
}

Console.Write("Insert num: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert divider1: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert divider2: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool result = IsMultipled(number, divider1, divider2);
Console.WriteLine($"Number {number} is divided on {divider1} and {divider2} is {result}");

if(result)
    Console.WriteLine($"Your number {number} is divisible by the {divider1} and {divider2}");
else 
      Console.WriteLine($"Your number {number} is not divisible by the {divider1} and {divider2}");
*/

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/* 
int BiggestNum(int num)
{
    int tens = num / 10;
    int units = num % 10;
    if (units > tens)
        return units;
    else 
        return tens;
}

int randNumber = new Random().Next(10, 100);
int big = BiggestNum(randNumber);
Console.WriteLine($"THe biggest sign of number {randNumber} is {big}");
*/

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool SquareOrNot(int num1, int num2)
{
    return (num1 / num2 == num2 || num2 / num1 == num1);
}

Console.Write("Please insert first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = SquareOrNot(num1, num2);
if (result) Console.WriteLine($"Number {num1} or number {num2} is a square of the other number");
else Console.WriteLine($"Number {num1} or number {num2} is not a square of the other number");
