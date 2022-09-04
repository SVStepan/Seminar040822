// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

// функция ввода значений
int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
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

// Функция 2 создания и заполнения двумерного массива случайными целыми числами 
void NewRandmatrix(int[,] matrix)
{
    Random matr = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i,j] = matr.Next(1,10); //  от 1 до 9
            Console.Write($"{matrix[i, j]}\t");
        }
    Console.WriteLine();    
    }
}

// Функция печати массива 
void PrintArray(int[,] matrix)              
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

int[,] array1 = FillIntRandArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array1);

Console.WriteLine("Задача 54 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

for (int i = 0; i < array1.GetLength(0); i++)  //проходим по строкам
{
    for (int j = 0; j < array1.GetLength(1); j++)  // Проходим по столбцам
    {
        for (int k = 0; k < array1.GetLength(1); k++)  // еще раз по столбецу
        {
            int temp = array1[i,j];  // временная переменная для запоминания индекса с максимальным значением
            if (array1[i,j] > array1[i,k])  // сравниваем значение в 1-й строке но в разных столбцах
            {
            array1[i,j] = array1[i,k]; // 
            array1[i,k] = temp;  // если значение в следующем столбце больше, то запомнием индекс
            }
        }
    }
}
Console.WriteLine("Упорядоченные по убыванию строки массива");
PrintArray(array1);

// функция поиска индекса с максимальным значением в строке массива
int MaxIDLine(int[,] array, int colum, int row) // принимаем 2-х мерный массив для поиска индекса с максимальным значением
{
    int columID = colum;
    for (int j = colum; j < array.GetLength(1); j++)
    {
        if (array[row,columID] < array[row,j])  // сравниваем значение в 1-й строке но в разных столбцах
        {
            columID = j; // если значение в следующем столбце больше, то запомнием индекс
        }
    }
    return columID;  // возвращаем индекс с максимальным значением 
} 

// функция упорядочивания столбцов по убыванию в линии 2-х мерного массива
int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array1.GetLength(0); i++)  //проходим по строкам
        {
            for (int j = 0; j < array1.GetLength(1); j++)  // Проходим по столбцам
            {
                int maxindex = MaxIDLine(array,j,i);
                int temp = array[i,j];
                array[i,j] = array[i,maxindex];
                array[i,maxindex] = temp;
            }
        }
    return array;
}
Console.WriteLine(" Задача 54 / вариант 2 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
SortArray(array1);
Console.WriteLine("Упорядоченные по убыванию строки массива");
PrintArray(array1);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] matrix1 = FillIntRandArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
// PrintArray(matrix1);

Console.WriteLine("Задача 56 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
// функция определения строки 2-х мерного массива с минимальной суммой значения
int[,] SuminLine(int[,] array)
{
    int sum = 0;
    int[] ar = new int[array1.GetLength(0)];
    for (int i = 0; i < array1.GetLength(0); i++)  //проходим по строкам
    {
        for (int j = 0; j < array1.GetLength(1); j++) // Проходим по столбцам
        {
            sum = sum + array1[i,j];
        }
        ar[i] = sum;
        Console.WriteLine($"сумма {i+1} -й строки {sum}; ");
        sum = 0;
    }

    int LineMinSum = ar[0];
    int MinSum = 1;
    for (int r = 0; r < array1.GetLength(0); r++)
    {
        if (ar[r] < LineMinSum)
            {
            LineMinSum = ar[r];
            MinSum = r+1;
            }
    }
    Console.WriteLine($"строка {MinSum} имеет минимальное значение {MinSum}; ");

    return array;
}
SuminLine(array1);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Задача 58 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

int[,] matrix1 = FillIntRandArray(Prompt("Введите число строк 1-й матрицы > "), Prompt("Введите число столбцов 1-й матрицы > "));
PrintArray(matrix1);
// int[,] matrix2 = FillIntRandArray(Prompt("Введите число строк 2- матрицы > "), Prompt("Введите число столбцов 2- матрицы > "));
// PrintArray(matrix2);

// int[,] matrix1 = new int[2,2];
// NewRandmatrix(matrix1);
// Console.WriteLine();

// Умножение матрицы A на матрицу B имеет смысл только в том случае, когда число столбцов матрицы A равно числу строк матрицы B.
// поэтому вторую матрицу создаем по параметрам первой матрицы, что бы не вводить размеры, перемножение которых не возможно
Console.WriteLine("Матрица - 2");  
int[,] matrix2 = new int[matrix1.GetLength(1),matrix1.GetLength(0)];
NewRandmatrix(matrix2);
Console.WriteLine();

Console.WriteLine("Перемноженная матрица");  

// функция перемножения матриц
void ProductMatrix (int[,] matrix11, int[,] matrix22)
{
    int[,] matrix3 = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix11.GetLength(0); i++)
    {
        for (int col2 = 0; col2 < matrix22.GetLength(1); col2++)
        {
            for (int r = 0; r < matrix22.GetLength(0); r++)
            {
                matrix3[i,col2] += matrix11[i,r] * matrix22[r, col2];
            }
            Console.Write($"{matrix3[i,col2]}\t");
        }
        Console.WriteLine();
    }
}

ProductMatrix(matrix1, matrix2);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел (от 10 до 99). Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine();
Console.WriteLine("Задача 60 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

// создаем 3-х мерный массив без проверки уникальности значений
int[,,] cub = new int[2,2,2];

for (int i = 0; i < cub.GetLength(0); i++)
{
    for (int j = 0; j < cub.GetLength(1); j++)
    {
        for (int c = 0; c < cub.GetLength(2); c++)
        {
            cub[i,j,c] = new Random().Next(10, 100);
        }
    }
}
// вывод 3-х мерного массива
void PrintCub(int[,,] cub)
{
    for (int i = 0; i < cub.GetLength(0); i++)
    {
        for (int j = 0; j < cub.GetLength(0); j++)
        {
            for (int c = 0; c < cub.GetLength(0); c++)
            {
                Console.Write($"{cub[i,j,c]} - ({i}, {j}, {c})\t");
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    }
}
PrintCub(cub);


// решение ниже не в зачет ДЗ так как сделано не самостоятельно. 
// После проведенного семинара 

Console.WriteLine("Введите параметры массива через пробел");
string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] cub1 = MatrixCub(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) },10, 99);
PrintCub(cub1);

// функция создания 3-х мерного массива
int[,,] MatrixCub(int[] sizes, int min, int max) //[row, colum, depth];
{
    int[,,] cub = new int[sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < cub.GetLength(0); i++)
    {
        for (int j = 0; j < cub.GetLength(1); j++)
        {
            int k = 0;
            while (k < cub.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (FindElemet(cub, element)) continue;
                cub[i, j, k] = element;
                k++;
            }
        }
    }
    return cub;
}
//  функция проверки уникального значения элемента
bool FindElemet(int[,,] array, int el)
{
    for (int i = 0; i < cub.GetLength(0); i++)
    {
        for (int j = 0; j < cub.GetLength(1); j++)
        {
            for (int c = 0; c < cub.GetLength(2); c++)
            {
                if(array[i,j,c] == el) return true;
            }
        }
    }
    return false;
}


Console.WriteLine();
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.WriteLine("Задача 62 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

//  решение подсказали
int[,] SpirallyArray(int s)
{
    int begin = 0;
    int count = 0;
    int element = s * s;
    int[,] array1 = new int[s, s];
    while (count < element)
    {
        for (int i = begin; i < s; i++)
        {
            count++;
            array1[begin, i] = count;
        }
        for (int i = begin + 1; i < s; i++)
        {
            count++;
            array1[i, s - 1] = count;
        }
        for (int i = s - 2; i >= begin; i--)
        {
            count++;
            array1[s - 1, i] = count;
        }
        for (int i = s - 2; i >= begin+1; i--)
        {
            count++;
            array1[i, begin] = count;
        }
        s -=1;
        begin+=1;
    }
    return array1;
}

int[,] Spiral = SpirallyArray(Prompt("Введите размер матрицы: "));
PrintArray(Spiral);
