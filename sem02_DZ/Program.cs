// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
int numb = new Random().Next(100, 999);
Console.WriteLine(numb);

int A = numb / 10;
int B = A % 10;
Console.WriteLine($"число {B}");
Console.WriteLine();
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("введите число:");
int numF = Convert.ToInt32(Console.ReadLine());

// int numF = new Random().Next(1, 9999);
// Console.WriteLine(numF);

string number = Convert.ToString(numF);
if (number.Length>=3)
{
Console.WriteLine(number[2]);
}
else 
{
    Console.WriteLine("третьей цифры нет");
}
Console.WriteLine();
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int dayofweek = new Random().Next(1,20); //1 2 3 ... 7;
Console.WriteLine(dayofweek);
//                         0              1         2        3           4         5            6
string[] daysofweek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

if ((dayofweek) > 7)
{
        Console.WriteLine("Нет дня недели соответсвующей введенной цифре");
        return;
}

if ((dayofweek) > 5)
{
    Console.WriteLine(daysofweek[dayofweek - 1]);
    Console.WriteLine("выходной день");
}
else
{
    Console.WriteLine(daysofweek[dayofweek-1]);
    Console.WriteLine("Это рабочий день");
}