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

// int[,] CreateRandom2dArray(int rows, int cols)
// {

//     Console.Write("Минимаьное значение массива? ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Максимальное значение массива? ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows,cols];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue);
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

// int[,] MatrixMulti(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayMulti = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

//     for(int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for(int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for(int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                 arrayMulti[i,j] += arrayA[i,k] * arrayB[k,j];
//             }
//         }
//     }
//     return arrayMulti;
// }

//     Console.Write("Количество строк массива A? ");
//     int rowsA = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Количество столбцов массива A? ");
//     int colsA = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Количество столбцов массива B? ");
//     int colsB = Convert.ToInt32(Console.ReadLine());

//     int[,] arrayA = CreateRandom2dArray(rowsA, colsA);
//     int[,] arrayB = CreateRandom2dArray(colsA, colsB);

//     ShowArray(arrayA);
//     ShowArray(arrayB);
//     ShowArray(MatrixMulti(arrayA, arrayB));

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[] UniqueCount(int count)
// {
//     Console.Write("Минимаьное значение массива? ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Максимальное значение массива? ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     if(maxValue - minValue <= count)
//     {
//         maxValue += count - (maxValue - minValue) + 1;
//     }

//     int[] array = new int[count];
//     int j = 0;

//     for(int i = 0; i < count; i++)
//     {
//         do
//         {
//             j = new Random().Next(minValue, maxValue);
//         }
//         while(Array.IndexOf(array, j) != -1);
        
//         array[i] = j;
//     }
//     return array;
// }

// int[,,] CreateRandom2dArray(int[] uniqueArray)
// {
//     int[,,] array = new int[2, 2, 2];
//     int count = 0;

//     for(int i = 0; i < 2; i++)
//     {
//         for(int j = 0; j < 2; j++)
//         {
//             for(int k = 0; k < 2; k++)
//             {
//                 array[i,j,k] = uniqueArray[count];
//                 count++;
//             }
//         }
//     }
//     return array;
// }

// void Show3dArray(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write(array[i,j,k] + " ");
//                 Console.Write("(" + i + " " + j + " " + k + ") ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Show3dArray(CreateRandom2dArray(UniqueCount(8)));

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] Create2dArray(int arraySize)
{
    int m = arraySize;
    int[,] array = new int[arraySize,arraySize];
    int k = 0;
    int count = 1;

    array[arraySize / 2, arraySize / 2] = arraySize * arraySize;

    for(int i = 0; i < arraySize / 2; i++)
    {
        for(int j = k; j < m - 1; j++)
        {
            if(count <= (arraySize * arraySize))
            {
                array[i,j] = count;
                count++;
            }
        }

        for(int j = k; j < m - 1; j++)
        {
            if(count <= (arraySize * arraySize))
            {
                array[j,m - 1] = count;
                count++;
            }
        }

        for(int j = m - 1; j > k; j--)
        {
            if(count <= (arraySize * arraySize))
            {
                array[m - 1, j] = count;
                count++;
            }
        }

        for(int j = m - 1; j > k; j--)
        {
            if(count <= (arraySize * arraySize))
            {
                array[j, i] = count;
                count++;
            }
        }
        m-=1;
        k++;
    }

    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Укажите размер массива? ");
int arraySize = Convert.ToInt32(Console.ReadLine());

ShowArray(Create2dArray(arraySize));