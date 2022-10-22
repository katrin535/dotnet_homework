/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.Write("Количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];

void ArrayOfNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i+=1)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length-1; i+=1)
    {
        Console.Write(numbers[i] + ", ");
    }
    for(int i = numbers.Length-1; i == numbers.Length-1; i+=1)
    {
        Console.Write(numbers[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}
ArrayOfNumbers(numbers);
Console.Write("Массив трехзначных чисел: ");

PrintArray(numbers);
int count = 0;

for (int ii = 0; ii < numbers.Length; ii+=1)
if (numbers[ii] % 2 == 0)
count+=1;
Console.WriteLine($"Четных чисел в массиве: {count}");






