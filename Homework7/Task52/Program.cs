/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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
double k1 = array2D[0,0] + array2D[0,1];
double k2 =
//double k3 =