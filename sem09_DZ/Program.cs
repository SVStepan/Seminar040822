// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

// функция вывода натуральных чисел от N до M
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(n, m));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int M, int N)
{
    int sum = n;
    for (int i = ++M; i <= N; i++)
    {
        sum += i;
        SumNumbers(++M, N);
    }
    return sum;
}

Console.WriteLine(SumNumbers(n, m));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29




