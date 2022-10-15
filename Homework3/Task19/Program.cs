﻿/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

    Console.Write("Введите пятизначное число: ");
        int a = int.Parse(Console.ReadLine());
        int palindrom = 0, n = a;
        while (a > 0) 
        {
            palindrom = palindrom * 10 + a % 10; 
            a /= 10;
        }
        Console.WriteLine(n == palindrom ? "Число является палиндромом" : "Число не является палиндромом");


    
