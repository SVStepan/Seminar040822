// 1. Напишите программ, которая на входе принимает число и выдает его квадрат (число умноженное на само себя)

// Console.Clear(); // Отчистка терминала

// Console.Write("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());  // конвертирование 
// int sqrt = num * num;
// // num *= num;   Методы умножения числа на себя, возведение в квадрат
// // sqrt1 = Convert.ToInt32(Math.Pow(num' 2));
// Console.Write("число в квадрате: " + sqrt);

// 2.  Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


// Console.Clear(); // Отчистка терминала
// Console.Write("введите число 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int sq = num2 * num2;
// if (num1 == sq)
//     Console.Write("Перво число является квадратом второго");
// else
//     Console.Write("Перво число не является квадратом второго");

// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

// Console.Clear(); // Отчистка терминала

// Console.Write("введите номер дня недели:");
// int day = Convert.ToInt32(Console.ReadLine());

// if(day < 1 || day >7)
// {
//     Console.Write("Нет такого дня недели");
// }
// else
// {
//     if (day == 1)
//     {
//         Console.Write("Понедельник");
//     }
//     if (day == 2)
//     {
//         Console.Write("Вторник");
//     }
//     if (day == 3)
//     {
//         Console.Write("Среда");
//     }
//     if (day == 4)
//     {
//         Console.Write("Четверг");
//     }
//     if (day == 5)
//     {
//         Console.Write("Пятница");
//     }
//     if (day == 6)
//     {
//         Console.Write("Суббота");
//     }
//     if (day == 6)
//     {
//         Console.Write("Воскресенье");
//     }
// }


// 4. Напишите программу, которая на входе принимает одно число (N) а на выходе показывает все целые числа в промежутке от -N до N

// Console.Clear(); // Отчистка терминала
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

// 5. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает посленюю цифру этого числа

Console.Clear(); // Отчистка терминала

int num = 735;
int lastnum = num % 10;  // % деление на модуль - нахождение остатка при деление на 10
Console.WriteLine(lastnum);

Console.WriteLine("Введите 3-х значное число:");
int n = Convert.ToInt32(Console.ReadLine());
int f = n % 10;  // % деление на модуль - нахождение остатка при деление на 10
Console.WriteLine(f);


int numberB = new Random().Next(100,999); //100 ... 999;
Console.WriteLine(numberB);
int B = numberB % 10;  // % деление на модуль - нахождение остатка при деление на 10
Console.WriteLine(B);