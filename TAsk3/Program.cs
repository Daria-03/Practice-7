// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int s = 3;
int n = 4;
int[,] numbers = new int[s, n];
Array2D(numbers);
PrintArray2D(numbers);

double[] Numbers = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    Numbers[i] = result / numbers.GetLength(0);
}
PrintArray(Numbers);

void Array2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);           // заполнение массива рандомными вещественными числами
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");               // вывод двумерного массива в терминал
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)                     // вывода массива в терминал 
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());                 // ввода 
}
