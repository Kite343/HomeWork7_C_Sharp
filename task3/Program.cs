/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] FillArray(int n = 4, int m = 5)
{
    int[,] array = new int [n, m];
    for (int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void SumColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        int count = array.GetLength(0);
        for(int i = 0; i < count; i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Среднее арифметическое {j + 1} столбца равно {(double)sum / count}");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {Console.Write("{0,4}", array[i, j]);}
        Console.WriteLine();
    }
}

int[,] myArray = FillArray();
PrintArray(myArray);
Console.WriteLine();
SumColumn(myArray);