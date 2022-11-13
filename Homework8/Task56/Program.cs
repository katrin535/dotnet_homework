/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/


Console.WriteLine($"Введите размер массива m x n:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
Console.WriteLine($"Рандомный массив m x n:");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int min = 0;
int summa = SummOfElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int summa2 = SummOfElements(array, i);
  if (summa > summa2)
  {
    summa = summa2;
    min = i;
  }
}

Console.WriteLine($"{min+1} - строкa с наименьшей суммой элементов = {summa} ");


int SummOfElements(int[,] array, int i)
{
  int summa = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    summa += array[i,j];
  }
  return summa;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,100);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
