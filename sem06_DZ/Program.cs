// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
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

int[] myArray = CreateArray();
ShowArray(myArray);
int numberpositive = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
    numberpositive++;
    }
    }

Console.WriteLine($"Положительных чисел введено: {numberpositive}");


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// double  b1 = 2;
// double  k1 = 5;
// double  b2 = 4;
// double  k2 = 9;
// double  y = 0;
// double  x = 0;

Double x;
Double y;
Double b1 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9;
Double b2 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9;
Double k1 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9;
Double k2 = new Random().Next(-10, 10); //-9 -8 -7 1 2 3 4 5 ... 9;
Console.WriteLine($"вводимые числа k1: {k1}, b1: {b1}, k2: {k2}, b2: {b2}");

if (b1 != b2 && k1 != k2)
{
    x = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"({x}; {y})");
}
else
{
    Console.WriteLine("Линии не пересекаются");
}

// Дополнительно (на оценку не влияют):

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("введите кол-во первых чисел Фибоначи "); // число 0 это значит что чисел нет. И нет смысла что-то выводить.
// колличество чисел не может быть отрицательным.
int F = Convert.ToInt32(Console.ReadLine());

if (F == 1)
{
    Console.WriteLine("0");
}
else
{
    int[] fibonachi = new int[F];
    fibonachi[0] = 0;
    fibonachi[1] = 1;
    for (int i = 2; i < F; i++)
    {
        fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
    }
    Console.WriteLine(String.Join(" ", fibonachi));
}



