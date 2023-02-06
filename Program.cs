// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double [,] array = new double[m, n];
// Random random = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = random.NextDouble() * 10;
//         Console.Write($"{Math.Round(array[i, j],2)} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите строку числа которое хотите найти: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец числа которое хотите найти: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 20);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// if (M <= m && N <= n && M > 0 && N > 0)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == M - 1 && j == N - 1)
//             {
//                 Console.WriteLine($"Число на строке {M} в столбце {N} -->  {array[i, j]} ");
//             }
//             continue;
//         }
//     }
// }
// else
// {
//     Console.WriteLine($"Числа на строке {M} в столбце {N} НЕТ ");
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
