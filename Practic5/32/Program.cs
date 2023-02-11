// Задача 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] numbers = {-4, -8, 8, 2};

// Console.WriteLine(string.Join(" ", numbers));
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] *= -1; 
// }
// Console.WriteLine(string.Join(" ", numbers));

System.Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите меньшее число массива");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите большее число массива");
int b = Convert.ToInt32(Console.ReadLine());


int[] numbers = new int[n];

// Console.WriteLine(string.Join(" ", numbers));
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(a, (b+1));
}
Console.Write($"[{string.Join(", ", numbers)}] ->");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= -1;
}
Console.Write($"[{string.Join(", ", numbers)}]");
