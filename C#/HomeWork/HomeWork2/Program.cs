/*
1. Task 1.
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

/*
int SecondDigit(int num)
{
    return (num / 10 % 10);
}

Console.Write("Plese insert a integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int second = SecondDigit(number);
Console.WriteLine($"Second sign of {number} is {second}");

*/

/* Task 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
int ThirdDigitOrNot(int num)
{
    int current = num;
    if(num > 100) 
        {
            while(num >= 100) 
            {
             current = num;
             num = num / 10;
            }
            return current % 10;
        }
    else return -1;
}

Console.Write("Plese insert a integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int third = ThirdDigitOrNot(number);

if (ThirdDigitOrNot(number) > 0) Console.WriteLine($"Third digit of the number {number} is {third}");
else Console.WriteLine($"There is no third digit in the number {number}");

*/

/* 
Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

/*
bool WeekendOrNot(int number)
{
    return (number > 5 && number < 8);
}

Console.Write("Plese insert a number of the day: ");
int number = Convert.ToInt32(Console.ReadLine());
if(WeekendOrNot(number) == true) Console.WriteLine($"Yes, number {number} is a weekend");
else Console.WriteLine($"No, number {number} is not a weekend");

*/