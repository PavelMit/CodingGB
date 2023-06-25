// Task 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double[,] CreatRandom2dDoubleArray()
// {
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a minimum possible value: ");
//     double minValue = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Input a maximum possible value: ");
//     double maxValue = Convert.ToDouble(Console.ReadLine());

//     double[,] array = new double[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1);
//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[,] newArray = CreatRandom2dDoubleArray();
// Show2dArray(newArray);


/* Task 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет
*/

/*
void IsThereNumberOrNot(int[,] array, int iIndex, int jIndex)
{
    if (iIndex < array.GetLength(0) && jIndex < array.GetLength(1)) Console.WriteLine($"The number with number of row {iIndex} and number of column {jIndex} is {array[iIndex,jIndex]}");
    else Console.WriteLine("Sorry, there is now number exist with those indexes");
}

int[,] newArray =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

Console.Write("Please input a number of row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input a number of column: ");
int column = Convert.ToInt32(Console.ReadLine());

IsThereNumberOrNot(newArray, row, column);
*/

/* Task 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] ArithmeticMeanOfColumns (int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
        result[j] = Math.Round(sum / array.GetLength(0), 1);
    }
    return result;           
}

int[,] newArray =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

Show2dArray(newArray);
double[] resultArray = ArithmeticMeanOfColumns(newArray);
for (int i = 0; i < resultArray.Length; i++)
{
    if (i == resultArray.Length - 1)
        Console.Write($"{resultArray[i]}.");
    else Console.Write($"{resultArray[i]}; ");
}
*/
