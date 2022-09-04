// 63 Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.

Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(1, n));

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNum(m, n));

string PrintNum(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Prompt(string messege)  //функция для ввода числовых значений через консоль
{
    System.Console.WriteLine(messege);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumChisel(int n)  // функция которая считает сумму введенных цифр в числе
{
    if (n % 10 == 0)
    {
        return 0;
    }
    else
    {
        return SumChisel(n / 10) + n % 10;
    }
}
Console.WriteLine(SumChisel(n));


// int PrintNumbers(int start, int end)
// {
//     Console.Write($"{start} ");
//     if (start == end) return start;
//     return  PrintNumbers(start + 1, end);
// }

// Console.Clear();
// Console.Write("Введите M: ");
// int numberM=int.Parse(Console.ReadLine()!);
// Console.Write("Введите N: ");
// int numberN=int.Parse(Console.ReadLine()!);

// PrintNumbers(numberM,numberN);


//Напишите программу, которая будет принимать на вход 
//число и возвращать сумму его цифр.

// Clear();
// Write("Введите число: ");
// int m = int.Parse(ReadLine());

// WriteLine($"{m}->{SumNumbers(m)}");

// int SumNumbers(int number)
// {
//     if (number == 0) return 0;
//     return (number % 10 + SumNumbers(number / 10));
// }



// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int A = Prompt("введите число А");
int B = Prompt("введите число В");

int MyRec(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    else
    {
        return a * MyRec(a, b - 1);
    }
}
Console.WriteLine(MyRec(A, B));


//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.

// Clear();
// Write("Введите число: ");
// int m = int.Parse(ReadLine());
// Write("Введите степень: ");
// int n = int.Parse(ReadLine());

// WriteLine($"{Pow(m,n)}");

// int Pow(int number,int rank)
// {
//     if (rank == 0) return 1;
//     if(rank==1) return number;
//     return (number * Pow(number,rank-1));
// }



// Console.Write("Введите базовое Число: ");
// int baseVal = int.Parse(Console.ReadLine());

// Console.Write("Введите степень Число: ");
// int exp = int.Parse(Console.ReadLine());

// int power(int baseValue, int exp) {
//     if (exp == 0) {
//         return 1;
//     } else {
//         return  baseValue * power(baseValue, exp -1);
//     }
// }
// Console.Write("В степен: " + power(baseVal, exp));
