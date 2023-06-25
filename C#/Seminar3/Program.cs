//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void ShowRange(int quad)
{
    if (quad == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quad == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quad == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quad == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine ("Incorrect input");
}

Console.WriteLine("Input quad number: ");
int quadNum = Convert.ToInt32(Console.ReadLine());
ShowRange(quadNum);
*/

//Task 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер четверти плоскости, в которой находится эта точка.

/*
int GetQuad(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input x coordinats: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinats: ");
double y = Convert.ToDouble(Console.ReadLine());
int result = GetQuad(x, y);
if (result == 0) Console.WriteLine("Incorrect input");
else Console.WriteLine($"Coordinats {x} and {y} are situated in {result} quad");
*/

// Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
double Distance(double xa, double ya, double xb, double yb)
{
    double powX = Math.Pow((xa - xb), 2);
    double powY = Math.Pow((ya - yb), 2);
    return Math.Sqrt(powX + powY);
}

Console.Write("Input x coordinats of first point : ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinats of first point : ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x coordinats of second point : ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinats of second point : ");
double yb = Convert.ToDouble(Console.ReadLine());

double result = Math.Round(Distance(xa, ya, xb, yb), 2);
Console.WriteLine($"Distanse is {result}");

*/

// Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void TableQuad(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.WriteLine($"{counter} -> {Math.Pow(counter, 2)}");
        counter++;
    }
}

Console.Write("Input integer number% ");
TableQuad(Convert.ToInt32(Console.ReadLine()));