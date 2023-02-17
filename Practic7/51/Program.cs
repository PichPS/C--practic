// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] EnterArr()
{
    System.Console.WriteLine("Введите количество строк массива");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите меньшее число строки массива");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите большее число строки массива");
    int b = Convert.ToInt32(Console.ReadLine());
    int[,] Rand = new int[m, n];
    for (int i = 0; i < Rand.GetLength(0); i++)
    {
        for (int j = 0; j < Rand.GetLength(1); j++)
        {
            Rand[i, j] = new Random().Next(a, (b + 1));
            System.Console.Write($"{Rand[i, j],4} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    return Rand;
}

int SUM(int[,] Array)
{
    int sum = 0;
    int count = 0;
    System.Console.Write("Cумма элементов главной диагонали: ");
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (i == j)
            {
                count = Array[i, j];
                sum += count;
            }

        }
        System.Console.Write($"{count}+");
        
    }
    System.Console.Write("\b");
    System.Console.Write($"= {sum} ");
    return sum;
}

SUM(EnterArr());

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
//             System.Console.Write($"{array[i, j],4}  ");
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


// int SumDiagonal(int[,] coll)
// {
//     int sum = 0;
//     for (int i = 0; i < coll.GetLength(0); i++)
//     {
//         for (int j = 0; j < coll.GetLength(1); j++)
//         {
//             if (i == j) sum += coll[i, j];
//         }
//     }
//     return sum;
// }


// int[,] arr = CreaateArray(Prompt("Введи кол-во строк: "), Prompt("Введи кол-во столбцов: "));
// arr = FillArrayRandom(arr);
// PrintArr(arr);
// System.Console.WriteLine(SumDiagonal(arr));