// Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int HowManyPositiveNumInput(int m)
{
    int counter = 0;
    for(int i = 0; i < m; i++)
    {
        Console.Write("Please input a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) counter++;
    }
    return counter;
}

Console.Write("How many numbers do you want to check: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 0)
{
    Console.Write($"Sorry, but {m} is not a positive numbers, for a quantity of number use a positive one. Try afain: ");
    m = Convert.ToInt32(Console.ReadLine());
}
int counter = HowManyPositiveNumInput(m);
Console.WriteLine($"There are {counter} positive numbers in your input");
*/

// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
void CrossPointOfTwoLines(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
        Console.WriteLine($"Lines with coordinates: k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} are parallel. There are no cross points of them");
    else 
    {
        if (k1 + b1 == k2 + b2) Console.WriteLine($"Lines with coordinates: k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} are equal");
        else 
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = (k1 * x) + b1;
            Console.WriteLine($"Lines with coordinates: k1 = {k1}, b1 = {b1} and k2 = {k2}, b2 = {b2} are crossing in coordinates x = {x}, y = {y}");
        }
    }
}

Console.WriteLine($"Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
CrossPointOfTwoLines(k1, b1, k2, b2);

*/