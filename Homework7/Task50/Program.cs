/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

00 01 02 03
1  4  7  2
10 11 12 13
5  9  2  3
20 21 22 23
8  4  2  4

17 -> такого числа в массиве нет*/

Console.Write("Введите позицию i элемента: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию j элемента: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] array2D = new int[,] { { 1, 2, 11, 21 }, { 3, 14, 22, 4 }, { 5, 8, 18, 19 } };
Console.WriteLine ("Задан массив: { 1, 2, 11, 21 }, { 3, 14, 22, 4 }, { 5, 8, 18, 19 }");
if (i < array2D.GetLength(0) && j < array2D.GetLength(1))
{
    Console.WriteLine($"[i,j] элемент в массиве: {array2D[i, j]}");
}
else
{
    Console.Write($"i = {i}, j = {j} - такого числа в массиве нет");
}