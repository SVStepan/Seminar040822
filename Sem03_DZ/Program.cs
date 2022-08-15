// ДЗ 

//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.Clear();

Console.WriteLine("введите число");
int P = Convert.ToInt32(Console.ReadLine());
// int P = 25152;
int K = 0;
int P1 = P;
if (P > 9999 && P < 100000)
{ 
    while (P1 > 0)  // (условие пока) (Условие продолжения)  оператор цикла
    {
        K = K * 10 + P1 % 10;
        P1 = P1 / 10;
    }
    if (K == P)
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число НЕ является палиндромом");
}
else
Console.WriteLine("число не является 5-и значным");

// решение коллег

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int num=Convert.ToInt32(Console.ReadLine());
// while (num<10000 && num<99999)
// {
//     Console.Write("Вы ввели не пятизначное число, исправьте: ");
//     int num2=Convert.ToInt32(Console.ReadLine());
//     if (num2>9999 && num2<100000)
//     {
//         num=num2;
//     }
// }
// if (num/10000==num%10 && num/1000%10==num/10%10)
//     {
//         Console.WriteLine($"Число {num} является палиндромом");
//     }
// else
// {
//     Console.WriteLine($"Число {num} не является палиндромом");
// }



// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine();

Double rasst;
int t1 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9; // Console.WriteLine(t1);
int s1 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9; // Console.WriteLine(s1);
int r1 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9; // Console.WriteLine(r1);
Console.WriteLine($"координаты 1-й точки : {t1}, {s1}, {r1}");

int t2 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9; // Console.WriteLine(t2);
int s2 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9; // Console.WriteLine(s2);
int r2 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9; // Console.WriteLine(r2);
Console.WriteLine($"координаты 2-й точки : {t2}, {s2}, {r2}");

rasst = Math.Sqrt(Math.Pow(t2 - t1, 2) + Math.Pow(s2 - s1, 2) + Math.Pow(r2 - r1, 2));
Console.WriteLine($"Расстояние = {rasst:f3}");
Console.ReadLine();



// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine();
Console.WriteLine("вводится число K");
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
    rez = i*i*i;
    Console.Write($" {rez},");
    i++;
}
// Решение коллег
// Console.Clear();
// Console.Write("Введите число N, я выведу таблицу кубов чисел от 1 до N: ");
// int N=Convert.ToInt32(Console.ReadLine());
// int ind = 1;
// if (N>0)
// {
//     while (ind<=N)
//     {
//         Console.Write(Math.Pow(ind,3) + ", ");
//         ind=ind+1;
//     }
// }
// else
// {
//     while (ind>=N)
//     {
//         Console.Write(Math.Pow(ind,3) + ", ");
//         ind=ind-1;
//     }
// }


// Console.Clear();
// Console.Write("put the number: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// int count = 1;
// while (count <= num)
// {
//     Console.Write($"|{Math.Pow(count++, 3)}| ");
// }

