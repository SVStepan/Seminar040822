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

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
