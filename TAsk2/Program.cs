// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//  значение этого элемента или же указание, что такого элемента нет.
//  Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет


int i = ReadInt("Введите индекс строки: ");
int column = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[6, 8];
Array2D(numbers);
PrintArray2D(numbers);

if (i < numbers.GetLength(0) && column < numbers.GetLength(1)) Console.WriteLine(numbers[i, column]);
else
{
    Console.WriteLine($"{i} , {column} -> Такого числа в массиве нет");
}


void Array2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);         // Заполнение массива рандомными числами от 1 до 9
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");                 // вывод массива в терминал
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());              // ввода
}
