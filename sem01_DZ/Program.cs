// 1. Написать программу, которая на входе принимает 2 числа и выдает (сравнивает) какое число больше и какое число меньше.
Console.Clear();
int numberA = new Random().Next(10, 99); //1 2 3 4 5 ... 9;
Console.WriteLine(numberA);
int numberB = new Random().Next(10, 99); //1 2 3 4 5 ... 9;
Console.WriteLine(numberB);

if (numberA > numberB)
{
    Console.WriteLine("Большее число:" + numberA);
    Console.WriteLine("Меньшее число:" + numberB);
}
else if (numberA < numberB)
{
    Console.WriteLine("Большее число:" + numberB);
    Console.WriteLine("Меньшее число:" + numberA);
}
else
{
    Console.WriteLine("цифры равны" + numberA);
}

// 2. Напишите программу, которая принимает на вход 3 числа и выдаёт максимальное из этих чисел.

Console.WriteLine();
int numA = new Random().Next(10, 99); //1 2 3 4 5 ... 9;
Console.WriteLine(numA);
int numB = new Random().Next(10, 99); //1 2 3 4 5 ... 9;
Console.WriteLine(numB);
int numC = new Random().Next(10, 99); //1 2 3 4 5 ... 9;
Console.WriteLine(numC);

int max = numA;

if (numA > max) max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;


Console.Write("max = ");
Console.WriteLine(max);

// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine();
int A = new Random().Next(10, 99); 
Console.WriteLine(A);

if (A % 2 == 0)
{
    Console.WriteLine("число четное: " + A);
}
else
{
    Console.WriteLine("число не четное: " + A);
}

// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Console.Clear();
// int N = 15;
// int i = -N;
// while (i <= N)
// {
//     Console.Write(i + " ");
//     i++;
// }

// Console.WriteLine();

// int m = new Random().Next(1, 15);
// int x = -m;
// while (x <= m)
// {
//     Console.Write(x + " ");
//     x++;
// }
// Console.WriteLine();

// 6. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// Console.Clear();

// int num = 735;
// int lastnum = num % 10;  // % деление на модуль - нахождение остатка при деление на 10
// Console.WriteLine(lastnum);

// Console.WriteLine("Введите 3-х значное число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int f = n % 10;  // % деление на модуль - нахождение остатка при деление на 10
// Console.WriteLine(f);


// int numberB = new Random().Next(100,999); //100 ... 999;
// Console.WriteLine(numberB);
// int B = numberB % 10;  // % деление на модуль - нахождение остатка при деление на 10
// Console.WriteLine(B);