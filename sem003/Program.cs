// Напишите программу, которая принимает на входе координаты точек (Х и Y) при чем не равные 0 и выдает номер четверти плоскости,
// в которой находится эта точка.

// решение без написанного ниже метода
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


// варианты решения коллег

//1)
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


//2)  используя функцию switch
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



// решение с ипользованием написанной функции (Метод)
Console.Clear();

void PrintQuarter(int x, int y) // Написали Метод определния четверти заданной точки, который далее можно где нибудь использовать
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


// int printQuarter(int a, int b)   // Метод
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

// Console.WriteLine ("Введите координаты а");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координаты b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Номер четверти : {printQuarter(a, b)}");




// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).


// работа коллег
//1)
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
Console.WriteLine();

int numbA = new Random().Next(1,8); //1 2 3 4 
Console.WriteLine("четверть : " + numbA );

if (numbA == 1)
{
    Console.WriteLine("X > 0, Y > 0 ");
}
if (numbA == 2)
{
    Console.WriteLine("X < 0, Y > 0");
}
if (numbA == 3)
{
    Console.WriteLine("X < 0, Y < 0");
}
if (numbA == 4)
{
    Console.WriteLine("X > 0, Y < 0");
}
else
Console.WriteLine("Такой четверти в 2-х мерной системе координат нет");


// 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine();
Double ras1;
int x1 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9;
// Console.WriteLine(x1);
int y1 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9;
Console.WriteLine($"координаты 1-й точки : {x1}, {y1}");
int x2 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9;
// Console.WriteLine(x2);
int y2 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9;
Console.WriteLine($"координаты 2-й точки : {x2}, {y2}");

ras1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние = {ras1:f3}");

Console.ReadLine();


// работа коллег
//1)
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

Console.WriteLine();
Console.WriteLine("введите число K");
int N1 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9;
Console.WriteLine(N1);
int i = 1;
int rez = 0;
if (N1 < 0)
{
    N1 = N1 * -1;
}
while (i <= N1)
{
    rez = i*i;
    Console.Write($" {rez},");
    i++;
}