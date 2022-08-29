// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Clear();
// Console.WriteLine("Введите номер строки: ");
// int str = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца: ");
// int row = Convert.ToInt32(Console.ReadLine());


// int[,] array = GetArray(6, 6, 0, 10);
// PrintArray(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void WantedArray(int[,] inArray)
// {
//     Console.Write($"Искомое число - " + inArray[str, row]);
//     for (int i = 0; i != str; i++)
//     {
//         for (int j = 0; j != row; j++);
//     }
// }

// WantedArray(array);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine());

// int [,] matrix = new int[rows, columns];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(0); j++)
//     {
//         matrix[i,j] = new Random().Next(0, 10);
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(0); j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
// }

// Console.Write($"Cреднее арифметическое столбцов: ");
// Console.WriteLine();
// for (int i = 0; i < columns; i++)
// {
//   double arithmeticMean = 0;
//   for (int j = 0; j < rows; j++)
//   {
//     arithmeticMean += matrix[j, i];
//   }
//   arithmeticMean = Math.Round(arithmeticMean / rows, 1);
//   Console.WriteLine($" № {i+1} - {arithmeticMean}");
// }
