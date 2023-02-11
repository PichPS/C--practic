// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

System.Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите меньшее число массива");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите большее число массива");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите промежуток для поиска. Введите начало промежутка: ");
int c = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конец промежутка: ");
int d = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(a, (b+1));
}
Console.Write($"[{string.Join(", ", numbers)}] ->");
int Count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] >= c && numbers[i] <= d) Count += 1;
}
System.Console.Write(Count);
