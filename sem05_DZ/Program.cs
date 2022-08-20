// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int N, int start, int end)  // создание случайного массива из N элементов  со значениями от 0 до 10, которые далеее надо вводить
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)  // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите количество элементов в массиве : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число случайно генерируемого диапазона : "); // от 100
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число случайно генерируемого диапазона : "); // до 999 
int max = Convert.ToInt32(Console.ReadLine());

if (min < 100 || max > 1000 )  // Проверка на ввод диапазона с 3-х значными числами.
{
    Console.WriteLine("в указанный диапазон входят не только 3-х значные числа");
    return;
}

int[] myRandArr = CreateRandomArray(num, min, max);
Console.Write("массив с положительными 3-х значными числами : ");
ShowArray(myRandArr);
Console.WriteLine("-------");


int count = 0;  // вводим переменную счетчика
int sum_not_even = 0; // вводим переменную счетчика суммы не четных чисел
int sum_even = 0; // вводим переменную счетчика суммы  четных чисел
int sum_poz_not_even = 0;  // вводим переменную сумма элементов позиций не четных чисел
int sum_poz_even = 0; // вводим переменную сумма элементов позиций четных чисел
int poz_sum_not_even =0; // вводим переменную суммы числе на не четных позициях массива
int poz_sum_even =0; // вводим переменную суммы числе на четных позициях массива
int difference = 0;
int Minimum = myRandArr[0];
int Maximum = myRandArr[0];
for (int i = 0; i < myRandArr.Length; i++)
{
    if (myRandArr[i] % 2 == 0)
    {
       Console.WriteLine(myRandArr[i] + " число четное");
       count = count + 1;
       sum_even = sum_even + myRandArr[i];
       sum_poz_even = sum_poz_even + i;
    }
    else
    {
        Console.WriteLine(myRandArr[i] + " число не четное");
        count = count + 0;
        sum_not_even = sum_not_even + myRandArr[i];
        sum_poz_not_even = sum_poz_not_even + i;
    }
        
    if (i % 2 == 0)
    {
        poz_sum_even = poz_sum_even + myRandArr[i];
    }
    else
    {
        poz_sum_not_even = poz_sum_not_even + myRandArr[i];
    }
    if (myRandArr[i] < Minimum)
        {
           Minimum = myRandArr[i];
        }
    if (myRandArr[i] > Maximum)
        {
        Maximum = myRandArr[i];
        }
        
    difference = Maximum - Minimum;

}

Console.WriteLine("-------");
Console.WriteLine($"В массиве 3-х значных чисел, четных чисел = {count}");
Console.WriteLine($"сумма не четных чисел = {sum_not_even}");
Console.WriteLine($"сумма четных чисел = {sum_even}");
Console.WriteLine("-------");
Console.WriteLine($"сумма элементов позиций не четных чисел = {sum_poz_not_even}");
Console.WriteLine($"сумма элементов позиций четных чисел = {sum_poz_even}");
Console.WriteLine("-------");

// решение задания массива и вывода как в лекции
// void FillArray(int[] collection)  // метод Fill заполнения массива случайными числами(данными от 100 до 1000) 1000 не входит 
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         collection[index] = new Random().Next(100, 1000);  // магические числа для универсальности надо заменять на переменные
//         // index = index + 1;
//         index++;
//     }
// }
// void PrintArray(int[] col)  // метод Print вывода массива 
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position] + ", ");
//         position++;
//     }
// }

// int[] array = new int[20];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// int count1 = 0;  // вводим переменную счетчика
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//        Console.WriteLine(array[i] + " число четное");
//        count1 = count1 + 1;
//     }
//     else
//     {
//         Console.WriteLine(array[i] + " число не четное");
//         count1 = count1 + 0;
//     }
// }

// Console.WriteLine($"четных чисел в массиве 3-х значными чисел = {count1}");
// Console.WriteLine("-------");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// условие и решение прописал в задаче выше. Здесь только вывод.
Console.WriteLine($"сумма не четных позиций элементов массива = {poz_sum_not_even}");
Console.WriteLine($"сумма  четных  позиций элементов массива = {poz_sum_even}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Задание выполнил с целыми числами!!!
// условие и решение прописал в задаче выше. Здесь только вывод.


Console.WriteLine("-------");
Console.WriteLine($"Максимальное число : {Maximum}");
Console.WriteLine($"Максимальное число : {Minimum}");
Console.WriteLine ($"разница между максимальным и минимальным числом массива = {difference}");




//  Math.Round(num / 10000, MidpointRounding.ToZero
