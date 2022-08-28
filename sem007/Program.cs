// Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[,] FillRandArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0) // Функция создания и заполнения двумерного массива случайными числами  
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

int[,] FillArray(int numLine, int numColumns) // Функция создания и заполнения двумерного массива числами  
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = i + j;      // [0; 20) по умолчанию 
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)              // Функция печати массива 
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

// int [,] array = FillArray(3,4);
int[,] array = FillArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array);

Console.WriteLine();

// Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1   4  7  2
// 5  81  2  9
// 8   4  2  4



int[,] ConvertToSQR(int[,] array1)   // Функция элементы, у которых обе позиции чётные и замениняем эти элементы на их квадраты.
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array1[i, j] = array1[i, j] * array1[i, j];
            }
        }
    }return array1;
}

int[,] array1 = FillRandArray(4,4);
PrintArray(array1);
Console.WriteLine();
int[,] newarray1 = ConvertToSQR(array1);
PrintArray(newarray1);


// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12
Console.WriteLine();
int[,] array2 = FillRandArray(3,3);
PrintArray(array2);
Console.WriteLine();
System.Console.WriteLine(GetSum(array2));

int GetSum(int[,] array2)
{
    int sum = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        // for (int j = 0; j < array2.GetLength(1); j++)
        // {
        //     if (i == j)
        //     {
                sum += array2[i,i];
    
    }
    return sum;
}


// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Введенный элемент 2, результат: [1, 4]

// Введенный элемент 6, результат: такого элемента нет.

Random rand = new Random();

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 15);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[3, 3];

FillMatrix(matrix);
PrintArray(matrix);
System.Console.WriteLine("Input a number: ");
int element = int.Parse(Console.ReadLine() ?? "0");
findElem(matrix, element);


void findElem (int[,] matrix, int element)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(element == matrix[i, j])
            {
              System.Console.WriteLine($"Entered number is on the [{i},{j}] position");
              return;
            }
        }

    }
    System.Console.WriteLine($"There is no such element in this matrix");

    
}




// Задача 4. Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их. Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

