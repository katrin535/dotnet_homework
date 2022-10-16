/*Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int summa (int a)
{
double st = 0;
double n = Convert.ToDouble(a);

while (n > 0)
 {
    st = st + n%10;
    n /= 10;
 }
return Convert.ToInt32(st);
}

Console.Write("Введите число: ");
int str = Convert.ToInt32(Console.ReadLine());
int s = summa (str -1);
Console.WriteLine("Сумма цифр в числе : " + s);



