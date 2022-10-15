/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число N: ");
string N = Console.ReadLine();
int a = Convert.ToInt32(N);
int i = 1;
int s = 0;
Console.Write ("Таблица кубов от 1 до N: ");
while (i <= a)
{
    s = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write (s + " "); 
    i += 1;
}
