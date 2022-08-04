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

Console.Clear(); // Отчистка терминала

Console.Write("введите номер дня недели:");
int day = Convert/ToInt32(Console.ReadLine());

if(day < 1 || day >7)
{
    Console.Write("Нет такого дня недели");
}
else
{
    if (day == 1)
    {
        Console.Write("Monday");
    }
    if (day == 2)
    {
        Console.Write("Tuesday");
    }
}
