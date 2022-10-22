/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.Write("Количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[n];

void ArrayOfNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i+=1)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(1,100)) / 100;
    }
}

void PrintArray(double[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length-1; i+=1)
    {
        Console.Write(numbers[i] + " ");
    }
    for(int i = numbers.Length-1; i == numbers.Length-1; i+=1)
    {
        Console.Write(numbers[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

ArrayOfNumbers(numbers);
Console.Write("Массив рандомных вещественных чисел: ");

PrintArray(numbers);

double minN = 100;
double maxN = 0; 

for (int ii = 0; ii < numbers.Length; ii+=1)
{
    if (numbers[ii] > maxN)
        {
            maxN = numbers[ii];
        }
    if (numbers[ii] < minN)
        {
            minN = numbers[ii];
        }
}
Console.WriteLine($"Разница между максимальным и минимальным значением массива: {Math.Round((maxN - minN), 3)}");