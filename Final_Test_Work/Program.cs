/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] array1 = new string[10] {"hello", "2", ":-)", "world", "1234", "1567", "computer science", "Russia", "Denmark", "Kazan"};
string[] array2 = new string[array1.Length];

void ArrayOfSymbols(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] arrayA)
{
    for (int i = 0; i < arrayA.Length; i++)
    {
        Console.Write($"{arrayA[i]} ");
    }
    Console.WriteLine();
}
ArrayOfSymbols(array1, array2);
PrintArray(array2);