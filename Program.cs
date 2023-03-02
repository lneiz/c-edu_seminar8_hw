// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Количество строк массива? ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Количество столбцов массива? ");
//     int cols = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Минимаьное значение массива? ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Максимальное значение массива? ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows,cols];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }

//     return array;
// }

// int[,] SortUpToLowArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = j; k < array.GetLength(1); k++)
//             {
//                 if(array[i,j] < array[i,k])
//                 {
//                     int change = array[i,j];
//                     array[i,j] = array[i,k];
//                     array[i,k] = change;
//                 }
//             }
//         }

//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }

//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// ShowArray(SortUpToLowArray(CreateRandom2dArray()));

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Количество строк массива? ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Количество столбцов массива? ");
//     int cols = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Минимаьное значение массива? ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Максимальное значение массива? ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows,cols];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }

//     return array;
// }

// void MinSumRow(int[,] array)
// {
//     int sum = 0;
//     int count = 0;
//     int rowNum = 0;

//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//             sum += array[i,j];
//         }
//         Console.Write(" сумма: " + sum);
//         Console.WriteLine();

//         if((i == 0) || (sum <= count))
//         {
//             count = sum;
//             rowNum = i + 1;
//             sum = 0;
//         }
//         sum = 0;
//     };
//     Console.Write(rowNum + " - строка с наимельншей суммой элементов");
// }

// MinSumRow(CreateRandom2dArray());

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandom2dArray(int rows, int cols)
{
    int[,] array = new int[rows,cols];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(0, 8);
        }
    }

    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMulti(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayMulti = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

    for(int i = 0; i < arrayA.GetLength(0); i++)
    {
        for(int j = 0; j < arrayB.GetLength(1); j++)
        {
            for(int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayMulti[i,j] += arrayA[i,k] * arrayB[k,j];
            }
        }
    }
    return arrayMulti;
}

    Console.Write("Количество строк массива A? ");
    int rowsA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов массива A? ");
    int colsA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов массива B? ");
    int colsB = Convert.ToInt32(Console.ReadLine());

    int[,] arrayA = CreateRandom2dArray(rowsA, colsA);
    int[,] arrayB = CreateRandom2dArray(colsA, colsB);

    ShowArray(arrayA);
    ShowArray(arrayB);
    ShowArray(MatrixMulti(arrayA, arrayB));