/*Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты.*/

int n = InputNumbers("Введите число N: ");
if (n == 0)
{
    Console.WriteLine("Введите число больше 0");
}
else
{
int[] NewArray = CreateArray(n);
CreateRows(NewArray);
}

void CreateRows(int[] ArrayOfNumbers)
{
  int[] arrayNN = new int[ArrayOfNumbers.Length];
  int m = 1;
  int count = 0;
  int Number1 = 0;
  int Number2 = 0;
  int NN2 = 0;
  
  for (int i = 0; i < ArrayOfNumbers.Length; i++)
  {
    Array.Clear(arrayNN);
    count = 0;
    if (ArrayOfNumbers[i] != 0)
    {
      arrayNN[count] = ArrayOfNumbers[i];
      Number2 = ArrayOfNumbers[i];

      for (int j = i; j < ArrayOfNumbers.Length; j++)
      {
        if (ArrayOfNumbers[j] % Number2 != 0 || ArrayOfNumbers[j] / Number2 == 1)
        {
          NN2 = 0;
          Number1 = ArrayOfNumbers[j];
          for (int k = 0; k < count; k++)
          {
            if (Number1 % arrayNN[k] == 0) NN2++;
          }
          if (NN2 == 0)
          {
            arrayNN[count] = ArrayOfNumbers[j];
            count++;
            ArrayOfNumbers[j] = 0;
          }
        }
      }
      Console.WriteLine($"Группа {m++}: {PrintIntArray(arrayNN)}");
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int[] CreateArray(int n)
{
  int[] temp = new int[n];
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = i + 1;
  }
  return temp;
}

string PrintIntArray(int[] array)
{
  string result = string.Empty;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] != 0) result += $"{array[i],1} ";
  }
  return result;
}
