/*
Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] FillArray(int n = 5)
{
    int[,] array = new int [n, n];
    for (int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return array;
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

void IndexsNumber(int n, int[,] array)
{
    bool flag = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == n) 
            {
                Console.WriteLine($"Позиция элемента в массиве {i} {j}");
                flag = false;
            }
        }
    }
    if(flag) Console.WriteLine("такого числа в массиве нет");
}

int GetNumber()
{
    Console.WriteLine("Введите число");
    string text = Console.ReadLine();

    string[] sentence ={"введите именно число", 
                        "Число! это дожно быть число!!! \nпопробуй еще раз", 
                        "Это не закончится до тех пор, пока не будет введено число.", 
                        "ты не знаешь что такое число? 1, 2, 5, 10... \nПопробуй еще раз. Я верю -ты сможешь!", 
                        "Это не число! Не ошибись! Ни чего кроме числа! одного числа!"};

    if(!int.TryParse(text, out int number))
    {
        Console.WriteLine(sentence[new Random().Next(0, 5)]);
        return GetNumber();
    }

    return number;
}

int[,] myArray = FillArray();
PrintArray(myArray);
Console.WriteLine();
IndexsNumber(GetNumber(), myArray);

