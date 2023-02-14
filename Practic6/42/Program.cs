// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string a = "";
while (n > 0)
{
    a = Convert.ToString(n % 2) + a;
    n /= 2;
}
System.Console.WriteLine(a);