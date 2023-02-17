// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
            Rand[i, j] = new Random().Next(-10, 10);
            System.Console.Write($"{Rand[i, j], 4}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    return Rand;
}

int[,] Find(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {

        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                Array[i, j] *= Array[i, j];
            }
           System.Console.Write($"{Array[i, j], 4}");
            
        }
        System.Console.WriteLine();
    }
    return Array;
}

Find(EnterArr());

// int Prompt(string massege)
// {
//     System.Console.Write(massege);
//     var readInput = Console.ReadLine();
//     int result = Convert.ToInt32(readInput);
//     return result;
// }


// int[,] CreaateArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     return array;
// }


// void PrintArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j], 4}  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] FillArrayRandom(int[,] coll)
// {
//     for (int i = 0; i < coll.GetLength(0); i++)
//     {
//         for (int j = 0; j < coll.GetLength(1); j++)
//         {
//             coll[i, j] = new Random().Next(-9, 10);
//         }

//     }
//     return coll;
// }


// int[,] FillArray(int[,] coll)
// {
//     for (int i = 0; i < coll.GetLength(0); i+= 2)
//     {
//         for (int j = 0; j < coll.GetLength(1); j += 2)
//         {
//             coll[i, j] *= coll[i, j];
//         }
//     }
//     return coll;
// }


// int[,] arr = CreaateArray(Prompt("Введи кол-во строк: "), Prompt("Введи кол-во столбцов: "));
// arr = FillArrayRandom(arr);
// PrintArr(arr);
// arr = FillArray(arr);
// System.Console.WriteLine();
// PrintArr(arr);
