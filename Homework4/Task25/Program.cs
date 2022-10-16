// Задача 25: опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// без math.pow

int stepen (int a, int b)
{
int i = 1;
int st = 1;
while (i <= b)
 {
   st = st * a;
   i+=1;
 }
return st;
}
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = stepen(a, b);
 Console.WriteLine("Число А в степени В: " + result);
