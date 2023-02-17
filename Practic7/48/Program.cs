// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
            Rand[i,j] = i+j;
            System.Console.Write($"{Rand [i , j], 4 }");
        }
          System.Console.WriteLine();
    }
  
    return Rand;
}

EnterArr();

// int SUM(int[,] Array)
// {
// int m = 0;
// int n = 0;
// for (int i = 0; i < Array.GetLength(0); i++)
// {
//     for (int j = 0; j < Array.GetLength(1); j++)
//     {
        
//     }
// }



