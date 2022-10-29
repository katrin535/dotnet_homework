/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Полученный массив из рандомных чисел:");
int[,] twoDimArray = new int[m, n];
Random rnd = new Random();
void PrintArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToInt32(rnd.Next(0, 100));}}}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);
double[] b=new double[n];
for (int j = 0,k =0;j<n;j++)
{
    {
        double summ = 0;
        for (int i = 0;i<m;i++)

        {summ += twoDimArray[i,j];}
        b[k] = summ/m;
        Console.WriteLine("Среднее арифметическое столбца "+(j+1)+" равно: "+ Math.Round(b[k], 2));
        k++;
    }
}