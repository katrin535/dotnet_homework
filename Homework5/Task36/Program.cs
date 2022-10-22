/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

Console.Write("Количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];

void ArrayOfNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i+=1)
    {
        numbers[i] = new Random().Next(1,100);
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
Console.Write("Массив рандомных чисел: ");

PrintArray(numbers);

int summ = 0;
for (int ii = 1; ii < numbers.Length; ii+=2)
summ =summ + numbers[ii];
Console.WriteLine($"Сумма элементов нечетных позиций: {summ}");