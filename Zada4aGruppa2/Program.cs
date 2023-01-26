// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
// 5 -> Пятница

Console.Write("Введите день недели: ");

int day_of_week = Convert.ToInt32(Console.ReadLine());

switch (day_of_week) 
{
	case 1: 
	Console.WriteLine("Понедельник");
break ;
    case 2:
	Console.WriteLine("Вторник");
    break ;
    case 3 :
	Console.WriteLine("Среда");
    break;
    case 5 :
	Console.WriteLine("Пятница");
    break;
}



