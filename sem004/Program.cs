// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

int GetSumNums(int number)  // функция суммы последовательных чисел
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++) // Math.Abs(number)  введенно число берем по модулю
    {
        sum += i;
    } 
    return sum;    // возвращает посчитанную сумму
}
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Cумма цифр от 1 до {num} введенного числа: {GetSumNums(num)}");
Console.WriteLine();

// работа коллег
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int x = 1; x <= Math.Abs(n); x++)  // цикл
{
    {
        sum += x;
    }
}
Console.WriteLine($"Сумма = {sum}");
Console.WriteLine();

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());  // максимальное кол-во цифр может быть 9. 10 уже зависает
int i = 0;
if (num1 == 0)
    Console.Write("1");
else
{    
    while(num1!= 0)
    {
        num1 = num1 / 10;
        i++;
    }
    Console.Write($"в числе {i} цифр");
}
Console.WriteLine();
Console.WriteLine();

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число: ");
int n1 = int.Parse(Console.ReadLine());
int work = 1;
if (n1 > 0)
{
// for (int x = 1; x <= Math.Abs(n); x++)
    for (int x = 1; x <= n1; x++)
    {
        work *= x;
    }
    Console.WriteLine($"сумма чисел от 1 до {n1} -> {work}");
}
else
{
    Console.WriteLine("введите положительное число от 1, иначе всегда будет 0");
}


// Задача сделана с помощью рекурсии
long fact(long numb)
{

    if (numb == 1)
    {
        return numb;
    }
    else
    {
        return numb * fact(numb - 1);
    }
}
Console.WriteLine("Введите число N");
long inputNumber = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Факториал числа " + fact(inputNumber));


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] array = new int [8];
// int number = new Random().Next(10,100);

Random ar = new Random();
Console.Write ("Случайный массив из 8 элементов в диапазоне [0,1] - ");
for ( int j = 0; j < 8; j++)
{
    array[j] = ar.Next(0,2);
    Console.Write (array[j] + " ");
}


// Задать целочисленный массив, состоящий из элементов 0 и 1. Например: [ 1, 1, 0, 0, 1, 0, 1, 1, 0, 0 ]. С помощью цикла и условия заменить 0 на 1, 1 на 0;
int[] arr1 = { 1, 1, 0, 0, 1, 0, 1, 1, 0, 0 };
Console.WriteLine();

for (int k = 0; k < arr1.Length; k++)
{
    if (arr1[k] == 1)
    {
        arr1[k] = 0;
    }
    else
    {
        arr1[k] = 1;
    }
    Console.Write(arr1[k] + " ");
}
Console.WriteLine();