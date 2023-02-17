// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] EnterArr()
{
    System.Console.WriteLine("Введите количество строк массива");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    // System.Console.WriteLine("Введите меньшее число строки массива");
    // int a1 = Convert.ToInt32(Console.ReadLine());
    // System.Console.WriteLine("Введите большее число строки массива");
    // int b = Convert.ToInt32(Console.ReadLine());
    int[,] Rand = new int[m, n];
    for (int i = 0; i < Rand.GetLength(0); i++)
    {
        for (int j = 0; j < Rand.GetLength(1); j++)
        {
            Rand[i,j] = new Random().Next(-10, 10);
            System.Console.Write($"{Rand [i , j], 4 }");
        }
          System.Console.WriteLine();
    }
  
    return Rand;
}
EnterArr();