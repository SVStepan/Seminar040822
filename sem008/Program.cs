// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

int[,] array1 = FillIntRandArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array1);

Console.WriteLine();

// Console.Clear();

// void fillMatrixWithRandomIntegers(int[,] matrix)
// {
//     Random rnd = new Random();
//     for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
//     {
//         for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
//         {
//             matrix[rowIndex, columnIndex] = rnd.Next(-10, 11);
//         }
//     }
// }

// void printMatrixOfIntegersToConsole(int[,] matrix)
// {
//     for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
//     {
//         Console.Write("\n");
//         for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
//         {
//             Console.Write($"  {matrix[rowIndex, columnIndex]}");
//         }
//     }
//     Console.Write("\n");
// }
// Console.WriteLine("Введите количество строк матрицы");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов матрицы");
// int n = Convert.ToInt32(Console.ReadLine());
// if (m < 1 || n < 1)
// {
//     Console.WriteLine("Некорректные значения");
// }
// else
// {   
// int[,] matrix = new int[m, n];
//     fillMatrixWithRandomIntegers(matrix);
//     printMatrixOfIntegersToConsole(matrix);
//     int indexFerstrool = 0;
//     int indexLastrool = m - 1;
//     int[] TempArray = new int[n];
//     for (int i = 0; i < n; i++)
//     {
//        TempArray[i] = matrix[indexFerstrool,i];
//     }
//     for (int i = 0; i < n; i++)
//     {
//         matrix[indexFerstrool,i] = matrix[indexLastrool,i];
//     }
//     for (int i = 0; i < n; i++)
//     {
//         matrix[indexLastrool,i] = TempArray[i];
//     }
//     Console.WriteLine("New matrix revers");
//     printMatrixOfIntegersToConsole(matrix);
// }


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.




//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

int[,] array = FillIntRandArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array);

Console.WriteLine();

int CountMatrixElement(array)
{
    int [] unkelemet = new int [array.GetLength(0)*array.GetLength(1)];
    int n = 0;
    for (int i = 0; i < array.length(0); i++)
    {
        for (int j = 0; j < array.length(1); j++)
        {
            for (int r = 0; r < n; r++)
            {
                if (unkelemet[r] = array[i,j])
                {

                }

            }
        }
    }
}



// Задача 59 Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7






// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника







