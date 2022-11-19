﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int m = InputNumber("Введите m: ");
int n = InputNumber("Введите n: ");
int Num = A(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {Num} ");

int InputNumber(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}
int A(int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if (n == 0 && m > 0)
{
return A(m - 1, 1);
}
else
{
return A(m - 1, A(m, n - 1));
}
}

