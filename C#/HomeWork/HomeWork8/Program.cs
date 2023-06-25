// Task 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] CreatRandom2dArray()
// {
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a minimum possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a maximum possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FromMaxToMinInRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int j2 = j; j2 >= 0; j2--)
//             {
//                 if (array[i, j2 + 1] > array[i, j2])
//                 {
//                     {
//                         int temp = array[i, j2];
//                         array[i, j2] = array[i, j2 + 1];
//                         array[i, j2 + 1] = temp;
//                     }
//                 }
//             }
//         }
//     }
// }

// int[,] newArray = CreatRandom2dArray();
// Show2dArray(newArray);
// FromMaxToMinInRows(newArray);
// Show2dArray(newArray);

/* 
Task 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив: 
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

// void RowWithLessSum(int[,] array)
// {
//     int lessRow = 0;
//     int numberOfLessSumRow = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int rowSum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//             rowSum += array[i, j];
//         if (i == 0 || rowSum < lessRow)
//         {
//             lessRow = rowSum;
//             numberOfLessSumRow = i;
//         }
//     }
//     Console.WriteLine($"Number of the first row with the less sum of elements is {numberOfLessSumRow + 1}");
// }

// int[,] newArray = CreatRandom2dArray();
// Show2dArray(newArray);
// RowWithLessSum(newArray);

/*
Task 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// int[,] MultiplyOfMatrix(int[,] array1, int[,] array2)
// {
//     int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
//     if (array1.GetLength(1) == array2.GetLength(0))
//     {
//         for (int i = 0; i < array1.GetLength(0); i++)
//             for (int j = 0; j < array2.GetLength(1); j++)
//                 for (int k = 0; k < array2.GetLength(0); k++)
//                     result[i, j] += array1[i, k] * array2[k, j];
//     }
//     else Console.WriteLine("Sorry, I can't multiple these matrixs");
//     return (result);
// }

// int[,] newArray1 =
// {
//     {2, 4},
//     {3, 2},
// };
// int[,] newArray2 =
// {
//     {3, 4},
//     {3, 3},
// };
// Show2dArray(newArray1);
// Show2dArray(newArray2);
// Show2dArray(MultiplyOfMatrix(newArray1, newArray2));

/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

// void Show3DArrayWithIndexes(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             Console.WriteLine();
//         }
// }

// int[,,] newArray = {
//     {
//         {66, 25},
//         {34, 41},
//     },
//     {
//         {27, 90},
//         {26, 55},
//     }
// };
// Show3DArrayWithIndexes(newArray);

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// void Show2dArrayWithZero(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10) Console.Write("0");
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] Spiral(int num)
// {
//     int[,] array = new int[num, num];
//     int counter = 1;
//     int turn = 1;
//     int i = 0;
//     int j = 0;
//     int plus = 0;
//     while (counter <= num * num)
//     {
//         if (turn == 1)
//         {
//             while (j + plus < array.GetLength(1))
//             {
//                 array[i, j] = counter;
//                 counter++;
//                 j++;
//             }
//             j--;
//             turn++;
//             i++;
//         }
//         else if (turn == 2)
//         {
//             while (i + plus < array.GetLength(0))
//             {
//                 array[i, j] = counter;
//                 counter++;
//                 i++;
//             }
//             i--;
//             turn++;
//             j--;
//         }
//         else if (turn == 3)
//         {
//             while (j - plus >= 0)
//             {
//                 array[i, j] = counter;
//                 counter++;
//                 j--;
//             }
//             j++;
//             i--;
//             plus++;
//             turn++;
//         }
//         else if (turn == 4)
//         {
//             while (i - plus >= 0)
//             {
//                 array[i, j] = counter;
//                 counter++;
//                 i--;
//             }
//             i++;
//             j++;
//             turn = 1;
//         }
//     }
//     return array;
// }

// Console.Write($"Please enter the size of spiral: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[,] spiral = Spiral(size);
// Show2dArrayWithZero(spiral);
