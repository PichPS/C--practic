// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

System.Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[n];

int SumPositive = 0;
int SumNegative = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-9, 10);
    if (numbers[i] > 0) SumPositive += numbers[i];
    else SumNegative += numbers[i];
}
Console.Write("[");
Console.Write(string.Join(", ", numbers));
Console.Write("]");
System.Console.WriteLine($"SumPositive {SumPositive} SumNegative {SumNegative}");

