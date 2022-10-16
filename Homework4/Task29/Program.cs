/*Задача 29: Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int[] ArrayMethod(string numbers)
{ 
int[] arrayA = new int[1];
 int j = 0;
 for (int i = 0; i < numbers.Length; i+=1)
 {
    string nunmersA = "";

    while (i < numbers.Length)
    {
      nunmersA += numbers[i];
    
      i+=1;
    }
    arrayA[j] = Convert.ToInt32(nunmersA);  
    j+=1;
  }
  return arrayA;
}

void Screen(int[] a)
{
  int n = a.Length;
  int i = 0;
  Console.Write("[");
  while(i < n)
  {
    Console.Write(a[i]);
    i+=1; 
  }
  Console.Write("]");
} 

Console.Write("Введите элементы массива : ");
string seriesOfNumbers = Console.ReadLine();
int[] arrayOfNumbers = ArrayMethod(seriesOfNumbers);
Screen(arrayOfNumbers);

 