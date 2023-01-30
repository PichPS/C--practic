// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число a: ");		// ввод 1-го числа
int a = Convert.ToInt32(Console.ReadLine());

int b = 7, c = 23 ;

if (a % b == 0 & a % c == 0)
{
Console.WriteLine($"{a} -> да");
}
else    
    if ((a % b != 0) || ( a % c != 0) )
        Console.WriteLine($" {a} -> нет ");
    
