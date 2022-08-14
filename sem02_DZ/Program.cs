// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
int numb = new Random().Next(100, 999);
Console.WriteLine(numb);

int A = numb / 10 % 10;
// int B = A % 10;
Console.WriteLine($"число {A}");
Console.WriteLine();


// другие решения коллег
//1)
// Console.WriteLine("Enter a three-digit number");
// int usersNumber = Convert.ToInt32(Console.ReadLine());

// if (1000 > usersNumber && usersNumber > 99)  // проверка на то что число является 3-х значным
// {
//  Console.Write("The entered number's second digit is: ");
//  Console.WriteLine(usersNumber / 10 % 10);
// }
// else 
// {
//  Console.WriteLine("Entered number isn't a three-digit number.");
// }

//2)
// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sec = number / 10;
// int sec2 = sec % 10;
// if (number >= 100 && number <= 999)
// {
//      Console.WriteLine(sec2);
// }
// else if (number <= 0)
// {
//      Console.WriteLine(-sec2);
// }
// else
// {
//      Console.WriteLine("Введено не трехзначное число");
// }


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

// другие решения коллег
//1)
// Console.WriteLine("Enter some number: ");
// int usersNumber = Convert.ToInt32(Console.ReadLine());
// int cycle = 0;

// while (cycle < usersNumber) {
//     if (usersNumber > 999) 
//     {
//         usersNumber = usersNumber / 10;
//     }
//     cycle++;
// }
// if (usersNumber > 99 && usersNumber < 1000) 
// {
//     Console.Write("The third digit is: ");
//     Console.WriteLine(usersNumber % 10);
// }
// else 
// {
//  Console.WriteLine("There's no third digit in your number.");
// }

//2)
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// char[] array = Math.Abs(num).ToString().ToCharArray();
// Console.WriteLine(array.Length > 3 ? $"Третья цифра введенного числа: {array[2]}": "Третьей цифры нет");


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
    //return;
}

if ((dayofweek) > 5 && dayofweek < 8 )
{
    Console.WriteLine(daysofweek[dayofweek - 1]);
    Console.WriteLine("выходной день");
}
else
{
    Console.WriteLine(daysofweek[dayofweek-1]);
    Console.WriteLine("Это рабочий день");
}


// другие решения коллег
//1)
// Console.Write("Работаем? ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 1 && number <= 5)
// {
//     Console.WriteLine("Да");
// }
// else if (number <= 0 || number >= 8)
// {
//     Console.WriteLine("Не в нашей вселенной)");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

//2
// Console.Write("Введите день недели ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day < 1 || day > 7)
// {
//     Console.Write("Не верно введен день");
// }
// else if (day <= 2 || day <= 5)
// {
//     Console.Write("Не является выходным");
// }
// else
// {
//     Console.Write("Ура, сегодня выходной!");
// }

//3)
// Console.WriteLine("введите число дня недели");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day > 5 && day < 8)
// {
//     Console.WriteLine("Выходной");
// }
// if (day <= 5)
// {
//     Console.WriteLine("Не выходной");

