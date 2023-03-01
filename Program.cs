// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Количество строк массива? ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов массива? ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимаьное значение массива? ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное значение массива? ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,cols];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

int[,] SortUpToLowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = j; k < array.GetLength(1); k++)
            {
                if(array[i,j] < array[i,k])
                {
                    int change = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = change;
                }
            }
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

ShowArray(SortUpToLowArray(CreateRandom2dArray()));

