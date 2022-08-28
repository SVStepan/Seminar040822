

Console.Clear();

// функция ввода значений
int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

// Функция создания и заполнения двумерного массива числами 
int[,] FillArray(int numLine, int numColumns)  
{
    int [,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = i + j;      
        }
    }
    return matrix;
}

// Функция создания и заполнения двумерного массива случайными целыми числами  
int[,] FillIntRandArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0)
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = new Random().Next(minRand, maxRand);      // [0; 20) по умолчанию 
        }
    }
    return matrix;
}

// Функция создания и заполнения двумерного массива случайными  с вещественными числами  
double [,] FillRandArray(int numLine, int numColumns, double maxRand = 20, double minRand = 0)
{
    double [,] matrix = new double [numLine, numColumns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = rand.NextDouble()*maxRand-minRand;      // [0; 20) по умолчанию 
        }
    }
    return matrix;
}

// Функция печати массива вещественныз чисел
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write("{0,6:F1}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

void PrintIntArray(int[,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

// int [,] array = FillArray(3,4);
double [,] array = FillRandArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array);
Console.WriteLine();

//решение коллег
// Double [,] ar = new double [4,4];
// Random rand = new Random();
// for (int i = 0; i < ar.GetLength(0); i++)
// {
//     for (int j = 0; j < ar.GetLength(1); j ++)
//         {
//             ar[i,j] = rand.NextDouble()*20-10;
//             Console.WriteLine("{0,6:F1}", ar [i,j]);
//         }
//         Console.WriteLine();
// }

// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


int [,] array2 = FillIntRandArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintIntArray(array2);

int ContLine = 0;
int ContColum = 0;

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        ContColum++;
    }
    ContLine++;
}
ContColum = ContColum / ContLine;

Console.WriteLine($"Столбцов - {ContColum}");
Console.WriteLine($"Линий - {ContLine}");
Console.WriteLine();

Console.WriteLine("Введите позицию строку Line");
int Line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбеца Colum");
int Colum = Convert.ToInt32(Console.ReadLine());

if (Line <= ContLine && Colum <= ContColum)
    {
        Console.WriteLine($"Значение элемента = {array2[Line-1,Colum-1]}");
    }
else
    {
        Console.WriteLine("Введенные значения позиций вышли за пределы масcива");
    }



// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// используем функцию  и элементы прошлого задания

Console.WriteLine();
double ArithmeticMean = 0;

for (int j = 0; j < array2.GetLength(1); j++)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        ArithmeticMean = ArithmeticMean + array2[i,j];
    }
    ArithmeticMean = ArithmeticMean / ContLine;
    Console.WriteLine($"среднее арифметическое {ArithmeticMean}; ");
    ArithmeticMean = 0;
}
