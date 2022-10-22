/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

Console.Write("Введите элементы через запятую: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i+=1)
{
    if (arr[i] > 0)
    {
        count+=1;
    }
}
 
Console.WriteLine($"Количество элементов больше 0: {count}");
