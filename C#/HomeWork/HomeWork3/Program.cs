/*
Task 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

/*
bool PolyndromOrNot(int number)
{
    if (number > -10 && number < 10)
    {
        Console.WriteLine("The number has only one digit and can't be a polydrom");
        return false;
    }
    int digit = 0;
    int current = number;
    int counter = 1;

    while (current != 0)
    {
        current /= 10;
        digit++;
    }

    while (counter < digit)
    {
        if ((number / Convert.ToInt32(Math.Pow(10,digit-1)))== number % 10)
        {
            digit = digit - 2;
            number = (number / 10) % Convert.ToInt32(Math.Pow(10, digit));
            counter++;
        }
        else return false;
    }
    return true;
}

Console.Write("Plese insert the number to check is it a polyndrom or not: ");
int number = Convert.ToInt32(Console.ReadLine());

if (PolyndromOrNot(number) == true) Console.WriteLine("The number is a polyndrom!");
else Console.WriteLine("The number is not a polyndrom!");

*/

/*
Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


/*
double Dist3D(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
}

Console.Write("Insert x coordinate of first point: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert y coordinate of first point: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert z coordinate of first point: ");
double za = Convert.ToDouble(Console.ReadLine());


Console.Write("Insert x coordinate of second point: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert y coordinate of second point: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert z coordinate of second point: ");
double zb = Convert.ToDouble(Console.ReadLine());
double result = Math.Round(Dist3D(xa, ya, za, xb, yb, zb), 2);

Console.WriteLine($"Distance between two point with coordinates is {result}");

*/

/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
void TableOfPower3(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.Write(Math.Pow(counter, 3));
        if (counter != number) Console.Write(", ");
        counter++;
    }
}

Console.Write("Please input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
TableOfPower3(number);
*/
