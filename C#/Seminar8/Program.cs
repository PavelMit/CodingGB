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
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

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

// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if (row1 >= 0 && row1 < array.GetLength(0) && 
//     row2 >= 0 && row2 < array.GetLength(0) && 
//     row1 != row2)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
// }

// int[,] newArray = CreatRandom2dArray();
// Show2dArray(newArray);

// Console.Write("Input a first row for changing: ");
// int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Input a second row for changing: ");
// int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

// ChangeRows(newArray, r1, r2);
// Show2dArray(newArray);

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

// void ChangeRowsOnColumns(int[,] array)
// {
//     if (array.GetLength(0) == array.GetLength(1))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     else Console.WriteLine("Sorry we can't do this because quantity of columns and rows are different. Restart the programm and input correct info");
// }

// int[,] newArray = CreatRandom2dArray();
// Show2dArray(newArray);

// ChangeRowsOnColumns(newArray);
// Show2dArray(newArray);

//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[] FindIndexOfMinNumber(int[,] array)
{
    int min = array[i, j] + 1;
    int iMin = 0;
    int jMin = 0;
    int[] minAray = {iMin, jMin};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i ,j] < min) 
            {
                min = array[i, j];
                iMin = i;
                jMin = j;
            }
        }
    }
    return minArray;
}

int[,] ArrayWithoutMinimum(int[,] array, int[] minArray)
{
    int[,] newArray = array;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == minArray[0]) i++;
            else if (j == minArray[1]) j++;
            else 
            {
                
            }
        }
}