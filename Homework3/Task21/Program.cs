/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

//-7-8 ^2 + 1-6 ^2 + 2-3 ^2

Console.Write("Введите координату x1 для А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 для А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1 для А: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x1 для B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 для B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1 для B: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double x = Math.Pow((x2 - x1), 2);
double y = Math.Pow((y2 - y1), 2);
double z = Math.Pow((z2 - z1), 2);
double sqrtsum = Math.Round(Math.Sqrt (x + y + z), 2);
Console.WriteLine("Расстояние между точками = " + sqrtsum);