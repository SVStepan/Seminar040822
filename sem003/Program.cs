// Напишите программу, которая принимает на входе координаты точек (Х и Y) при чем не равные 0 и выдает номер четверти плоскости,
// в которой находится эта точка.

// Console.Clear();
// Console.WriteLine("Вводим х");
// int x = new Random().Next(-10,10); //-9 -8 -7 1 2 3 4 5 ... 9;
// // int x = Convert.ToInt32(Console.WritLine());
// Console.WriteLine(x);
// Console.WriteLine("Вводим y");
// int y = new Random().Next(-10,10); //-9 -8 -7 1 2 3 4 5 ... 9;
// // int y = Convert.ToInt32(Console.WritLine());
// Console.WriteLine(y);

// if (x>0 && y>0)
// {
//  Console.WriteLine("точка приналежать 1-й четверти плоскости");
// }
// else if (x<0 && y>0)
// {
//  Console.WriteLine("точка приналежать 2-й четверти плоскости");
// }
// else if (x<0 && y<0)
// {
//  Console.WriteLine("точка приналежать 3-й четверти плоскости");
// }
// else if (x>0 && y<0)
// {
//  Console.WriteLine("точка приналежать 4-й четверти плоскости");
// }
// else
// {
//     Console.WriteLine("точка не приналежать никакой четверти плоскости");
// }

// варианты решения


// if (x > 0)
// {
//     if (y > 0)
//     {
//     Console.WriteLine("точка приналежать 1-й четверти плоскости");
//     }
//     else
//     {
//         Console.WriteLine("точка  приналежать 4-й четверти плоскости");
//     }
// }

// if (x < 0)
// {
//     if (y > 0)
//     {
//     Console.WriteLine("точка  приналежать 2-й четверти плоскости");
//     }
//     else
//     {
//     Console.WriteLine("точка  приналежать 3-й четверти плоскости");   
//     } 
// }

// Console.Write("Введите координаты точки X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты точки Y: ");
// int y = int.Parse(Console.ReadLine()!);
// string mes = "";

// switch (x, y)
// {
//     case (>0, >0): mes = "1"; break;
//     case (>0, <0): mes = "4"; break;
//     case (<0, >0): mes = "2"; break;
//     case (<0, <0): mes = "3"; break;
//     default : mes = "введите отличное от 0"; break;
// }
// Console.WriteLine(mes);




Console.Clear();

void PrintQuarter(int x, int y) // Метод определния четверти заданной точки
{

if (x>0 && y>0)
{
 Console.WriteLine("точка приналежать 1-й четверти плоскости");
}
else if (x<0 && y>0)
{
 Console.WriteLine("точка приналежать 2-й четверти плоскости");
}
else if (x<0 && y<0)
{
 Console.WriteLine("точка приналежать 3-й четверти плоскости");
}
else if (x>0 && y<0)
{
 Console.WriteLine("точка приналежать 4-й четверти плоскости");
}
else
{
    Console.WriteLine("точка не приналежать никакой четверти плоскости");
}
}

Console.WriteLine("Вводим х");
int x = new Random().Next(-10,10); //-9 -8 -7 1 2 3 4 5 ... 9;
// int x = Convert.ToInt32(Console.WritLine());
Console.WriteLine(x);
Console.WriteLine("Вводим y");
int y = new Random().Next(-10,10); //-9 -8 -7 1 2 3 4 5 ... 9;
// int y = Convert.ToInt32(Console.WritLine());
Console.WriteLine(y);
PrintQuarter(x, y);

// int printQuarter(int a, int b)
// {
//     if (a>0 && b>0)
//     {
//         return 1;
//     }
//     else if (a<0 && b>0)
//     {
//         return 2;
//     }
//     else if (a<0 && b<0)
//     {
//         return 3;
//     }
//     else if (a>0 && b<0)
//     {
//         return 4;
//     }
//     else
//     {
//         return 0;
//     }
// }


// Console.WriteLine ("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Номер четверти - {printQuarter(x, y)}");

// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int quarter=int.Parse(Console.ReadLine());

// switch (quarter)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0 y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x<0 y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x<0 y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("x>0 y<0");
//         break;
//     }
    
//     default:
//     {
//         Console.WriteLine("Введена неправильная четверть");
//         break;
//     }
// }


// 18 Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


// 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// Console.Clear();
// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));

// Console.WriteLine($"d={d:f2}");



// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// ДЗ 

//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125
