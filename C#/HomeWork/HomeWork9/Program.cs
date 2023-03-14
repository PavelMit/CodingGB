/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// void PrintNums(int num)
// {
//     if (num > 0)
//     {
//         Console.Write(num);
//         if (num != 1) Console.Write(", ");
//         PrintNums(num - 1);
//     }
// }

// Console.Write("Please input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintNums(number);


/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// int SumOfElements(int M, int N)
// {
//     if (M > N)
//         return SumOfElements(M - 1, N) + M;
//     else if (M < N)
//         return SumOfElements(M, N - 1) + N;
//     return M;
// }
// Console.WriteLine(SumOfElements(4, 8));

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

// double Accerman(double m, double n)
// {
//     // double result = 0;
//     if (m == 0 && n != 0) return n + 1;
//     else if (n == 0 && m != 0) return Accerman(m - 1, n + 1);
//     else return Accerman(m - 1, Accerman(m, n - 1));
// }
// Console.Write("Please input value for 'm': ");
// double m = Convert.ToDouble(Console.ReadLine());
// Console.Write("Please input value for 'n': ");
// double n = Convert.ToDouble(Console.ReadLine());
// double result = (Accerman(m, n));
// Console.WriteLine($"Result fo Accerman function of values {m} and {n} is {result}");
