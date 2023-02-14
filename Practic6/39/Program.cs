// Задача 39: Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] EnterArr()
{
    System.Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите введите нижнюю границу массива");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите верхнюю границу массива");
    int b = Convert.ToInt32(Console.ReadLine());
    int[] Rand = new int[n];
    for (int i = 0; i < Rand.Length; i++)
    {
        Rand[i] = new Random().Next(a, (b + 1));
    }
    System.Console.Write($"[{string.Join(", ", Rand)}] -> ");
    return Rand;
}
int[] ReversArr(int[] Array)
{
  for (int i = 0, j = Array.Length - 1; i < Array.Length / 2; i++, j--)
    {
        int tmp = Array[j];
        Array[j] = Array[i];
        Array[i] = tmp;
    }
    System.Console.Write($"[{string.Join(", ", Array)}]");
    return Array;
}
ReversArr(EnterArr());