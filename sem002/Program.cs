// Написать программу которая выводит случайные числа из отрезка [10, 99] и показывает наибольшую цифру
Console.Clear();
int numb = new Random().Next(10, 100);
Console.WriteLine(numb);

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int A = num / 10;
// Console.WriteLine(A);
int D = A / 10;
// Console.WriteLine(D);
int B = num % 10;
// Console.WriteLine(B);
Console.WriteLine($"число {D}{B}");


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("введите первое число:");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число:");
int M = Convert.ToInt32(Console.ReadLine());

if (M % N == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine($"Второе число не кратно первому, остаток от деления: {M % N}");
}

if (N % M == 0)
{
    Console.WriteLine("первое число кратно второму");
}
else
{
    Console.WriteLine($"Первое число не кратно второму, остаток от деления: {N % M}");
}

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
// int number1 = new Random().Next(100, 1000);
// Console.WriteLine(number1);
int x = 7;
int z = 23;

if (number1 % x == 0)
{
    Console.WriteLine("number1 кратно 7");
}
else 
Console.WriteLine("number1 не кратно 7");

if (number1 % z == 0)
{
    Console.WriteLine("number1 кратно 23");
}
else 
Console.WriteLine("number1 не кратно 23");


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("введите число number2:");
int number2 = Convert.ToInt32(Console.ReadLine());
// int number2 = new Random().Next(100, 1000);
// Console.WriteLine(number2);
Console.Write("введите число number3:");
int number3 = Convert.ToInt32(Console.ReadLine());
// int number3 = new Random().Next(100, 1000);
// Console.WriteLine(number3);

if (number2 * number2 == number3)
{
    Console.WriteLine("number3 является квадратом number2");
}
else 
Console.WriteLine("number3 не является квадратом number2");

if (number3 * number3 == number2)
{
    Console.WriteLine("number2 является квадратом number3");
}
else
Console.WriteLine("number2 не является квадратом number3");
