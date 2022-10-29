/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.WriteLine("Задайте количество строк 1 - го двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов 1-го двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество строк 2 - го двумерного массива:");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов 2-го двумерного массива:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1 матрица из рандомных чисел:");
int[,] oneDimArray = new int[m, n];
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
FillArray(oneDimArray);
Console.WriteLine();
PrintArray(oneDimArray);

Console.WriteLine("2 матрица из рандомных чисел:");
int[,] twoDimArray = new int[m2, n2];
Random rnd2 = new Random();
void PrintArray2(int[,] matr2)
{ for (int i = 0; i < m2; i++)
 { for (int j = 0; j < n2; j++)
 { Console.Write($"{matr2[i, j]} ");}
 Console.WriteLine();}}

void FillArray2(int[,] matr2)
{ for (int i = 0; i < m2; i++)
 { for (int j = 0; j < n2; j++)
 { matr2[i,j] = Convert.ToInt32(rnd2.Next(0, 100));}}}
FillArray2(twoDimArray);
Console.WriteLine();
PrintArray2(twoDimArray);

Console.WriteLine("Произведение 2-х матриц: ");
int[,] r = new int[m2, n2];
 for (int i = 0; i < oneDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimArray.GetLength(1); j++)
                {
                    for (int k = 0; k < twoDimArray.GetLength(0); k++)
                    {
                        r[i,j] += oneDimArray[i,k] * twoDimArray[k,j];
                    }
                    Console.Write(r[i, j] + " ");
                }
                Console.WriteLine();
            }

