// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

System.Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите меньшее число массива");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите большее число массива");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число для поиска");
int c = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[n];
// int[] numbers = {6, 7, 19, 345, 3};


for (int i = 0; i < numbers.Length; i++)
{
     numbers[i] = new Random().Next(a, (b-1));
}
Console.Write($"{c}; массив [{string.Join(", ", numbers)}] -> ");

int find = c;
String Ans = "Нет";
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == find)
    {
        Ans = "Да";
        break;
    }
}
System.Console.Write(Ans);
