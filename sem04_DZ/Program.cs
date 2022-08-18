// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

Console.Write("введите первое число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число b:");
int b = Convert.ToInt32(Console.ReadLine());
int rez = a;
for (int i = 1; i < b; i++)
    {
        rez = rez * a;
    }

Console.Write(rez);
Console.WriteLine();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int summ = 0;

while (num > 0)
{
    summ = summ + num % 10;
    num /= 10;
}
Console.WriteLine("Сумма = :");
Console.WriteLine(summ);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int [8];

Random ar = new Random();
Console.Write ("Массив из 8 элементов в диапазоне [0,99] - ");
for ( int j = 0; j < 8; j++)
{
    array[j] = ar.Next(0,100);
    Console.Write (array[j] + " ");
}

