/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] FillArrayDouble(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 11) + new Random().NextDouble();
        }
    }
    return array;
}

void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {Console.Write($"{array[i, j]:f2}\t");}
        Console.WriteLine();
    }
}

Console.WriteLine("Поочередно введите размер матрицы m на n");
double[,] myArray = FillArrayDouble(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
PrintArrayDouble(myArray);
