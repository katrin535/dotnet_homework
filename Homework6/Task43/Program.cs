﻿/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

//y-y = k1*x+b1 -k2*x-b2
//k1*x+b1-k2*x-b2=0
//x(k1-k2)+b1-b2=0
//-x=(b1-b2) / (k1-k2)
//x=-(b1-b2) / (k1-k2)
//y=k2*x+b2

double x = -(b1-b2) / (k1 - k2);
double y = k2 * x + b2;
  
Console.WriteLine($"Пересечение двух прямых в точке: ({Math.Round(x, 2)};{Math.Round(y, 2)})");
