// Семинар 05
Console.Clear();

int[] CreateRandomArray(int N, int start, int end)  // создание случайного массива из N элементов  со значениями от 0 до 10, которые далеее надо вводить
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int[] CreateArray()  // создание  массива с N-м колчиством элементов и вводом в ручном режиме каждого значения элемента массива
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");  // поочередно вводятся руками все значения массива с N-м колчиством элементов
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
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
Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);
ShowArray(myRandomArray);
Console.WriteLine("-------");

// int[] myArray = CreateArray(); создаем массив с N-м колчиством элементов и вводом в ручном режиме каждого значения элемента массива
// ShowArray(myArray);

// Решение Mаксима через цикл

// Random num1 = new Random();

// Console.Write("Input the length of the array: ");
// int length = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the beginning of the range: ");
// int start = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the end of the range: ");
// int end = int.Parse(Console.ReadLine()!);
// int[] array = new int[length];

// for(int i = 0; i < length; i++)
// {
//     array[i] = num1.Next(start,end);
//     Console.Write(array[i]+ " ");
// }

// Random rand = new Random();
// int[] array = new int[8];
// Console.Write("[");
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0, 11);
//     Console.Write($"{array[i]}" + (i < array.Length - 1 ? ", " : ""));
// }
// Console.Write("]");
// Гая, добавил пару строчек в твой код)




// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// CreateRandomArray метод выше
// ShowArray  метод выше

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

int sum_pos = 0;
int sum_neg = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
        sum_pos += myArray[i];
    else
        sum_neg += myArray[i];
}

Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");
Console.WriteLine();


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// CreateRandomArray метод выше

int[] moyarray = CreateRandomArray(8,-10,11);
Console.WriteLine(String.Join(",",moyarray));
for (int i = 0; i < moyarray.Length; i++)
{
    moyarray[i]=-moyarray[i];
}
Console.WriteLine(String.Join(",",moyarray));



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// CreateRandomArray метод задачи выше
// ShowArray  метод выше

// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение random в массиве");
// int random = Convert.ToInt32(Console.ReadLine());

// bool flag = false;
// int [] array = CreateRandomArray(num, min, max);
// ShowArray(array);

// for (int i = 0; i < array.length; i++)
// {
//     if (array[i] == random)
//     {
//         flag = true;
//     }
// if (flag == true)
// {
//     Console.WriteLine($"Число присутсвует в массиве: " + random)
    
// }
// else
//     {
//          Console.WriteLine("Не присутствует");
//     }

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



int[] myArray1 = CreateRandomArray(123, 0, 200);
ShowArray(myArray1);
for (int i = 0; i < myArray1.Length; i++)
{
    if (myArray1[i] >= 10 && myArray1[i] <= 99)
    {
        Console.Write($"{myArray1[i]}"+ "|");
    }
    else
    Console.Write("-");
}



// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int result = 0;
// int a = myArray.Length -1;
// for (int i = 0; i < myArray.Length/2 ; i++)
// {
//     result = myArray[i] * myArray[a];
//     a -= 1;
//     Console.Write($"[{String.Join(",", result)}]");
// }
// if(myArray.Length%2 != 0)
// {
//     Console.Write($"[{String.Join(",", myArray[myArray.Length/2])}]");
// }
