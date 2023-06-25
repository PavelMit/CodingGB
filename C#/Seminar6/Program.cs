// Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - 
// на последнем и т.д.)

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }


// void ReverseArray(int[] array)
// {
//     for (int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }


// Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник 
// с сторонами такой длины.

bool IsTrianglePossible (int a, int b, int c) 
{
    return (a < b + c && b < a + c && c < a + b);
}

Console.Write("Введите длину первой стороны: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третьей стороны: ");
int c = Convert.ToInt32(Console.ReadLine());

if (IsTrianglePossible(a, b, c) == true) Console.WriteLine("Треугольник возможен");
else Console.WriteLine("Треугольник не возможен");

//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: a и b.

// int[] Fibonacci (int N, int a, int b)
// {
//     int[] array = new int[N];
//     array[0] = a;
//     array[1] = b;
//     for(int i = 2; i < N; i++)
//         array[i] = array[i-1] + array[i-2];
//     return array;
// }


// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество чисел в последовательности: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] array = Fibonacci(N, a, b);
// ShowArray(array);

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] CopyArray(int[] array)
// {
//     int[] result = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//         result[i] = array[i];
//     return result;
// }

// Console.Write("Введите минимальное число в массиве: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максмимальное число в массиве: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreatRandomArray(size, min, max);
// ShowArray(newArray);
// Console.WriteLine();
// int[] newArray1 = CopyArray(newArray);
// newArray1[0] = 20;
// ShowArray(newArray1);

// 15 % 2 = 1
// 7 $ 2 = 1
// 3 % 2 = 1
// 1 % 2 = 1 


// string ToBinary(int number)
// {
//     string result = string.Empty;
//     while (number > 0)
//     {
//         result = Convert.ToString(number % 2) + result;
//         number /= 2;
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string binary = ToBinary(number);
// Console.WriteLine(binary);