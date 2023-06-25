//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] CreatRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimum possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++ )
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Задайте двумерный массив размера m на n, каждый элемент в 
// массиве находится по формуле: Aij = i + j. Выведите полученный массив на экран.

// int[,] CreatArray (int rows, int columns)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i,j] = i + j;
//     return array;
// }

// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreatArray (rows, columns);
// Show2dArray(newArray);

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int[,] ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i += 2)
//         for (int j = 0; j < array.GetLength(1); j += 2)
//             array[i,j] *= array[i,j];
//     return array;
// }

// int[,] newArray = CreatRandom2dArray();
// Show2dArray(newArray);
// ChangeArray(newArray);
// Show2dArray(newArray);

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int GetSumDiagonal(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        result += array[i, i];
    return result;
}

int[,] newArray = CreatRandom2dArray();
Show2dArray(newArray);
Console.WriteLine(GetSumDiagonal(newArray));

