// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

Console.Write("введите первое число а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите степень b:");
int b = Convert.ToInt32(Console.ReadLine());

int rez = 0;
rez = a;
for (int  i = 1; i < b; i++)
    {
        rez = a * rez ;
    }

Console.WriteLine (rez);
Console.WriteLine();


// Console.WriteLine($"{a} в степень {b} = {Pow(a,b)}");   // решение через метод


// int Pow(int num1, int step)
// {
//     if (b == 0) return 1;
//     int rez = num1;
// for (int i = 2; i <= step; i++)
//     {
//         //rez = rez * a;
//         rez *= num1;
//     }
//     return rez;
// }

// Console.WriteLine();


// 25  решение коллег

// Console.WriteLine("Enter a number: ");
// int numA = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("And its power: ");
// int numB = int.Parse(Console.ReadLine() ?? "0");
// numB = Math.Abs(numB);
// int firstA = numA;
// int i = 0;

//Console.WriteLine($"{numA} raised to a power {numB} = {Math.Pow(numA, numB)}");

// if (numA == 0)
// {
//     Console.WriteLine($"{firstA} raised to a power {numB} = {numA}");    
// }

// else 
// {
//     while (i < numB) 
//     {
//         numA *= firstA;
//         i++;
//     }
//     numA /= firstA;
//     Console.WriteLine($"{firstA} raised to a power {numB} = {numA}");
// }


// Console.Write("Введите A: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Введите B: ");
// int number2 = int.Parse(Console.ReadLine());

// int num = Convert.ToInt32(Math.Pow(number1, number2));
// Console.WriteLine(num);




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

// //29

// Random rand = new Random();
// int [8] arr;
// for(int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rand.Next();
//     Console.Write($" {arr[i]},");
// }

// решение преподователя по ДЗ

Console.WriteLine();
int[] arra = GetRandomArray(8,0,100);
Console.WriteLine($"Массив из 8 элементов, [{String.Join(", ", arra)}]");

int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue);
    }

    return result;
}