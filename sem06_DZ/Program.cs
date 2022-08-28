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


// решение коллег 1
// Console.Clear();
// Console.Write("Введите через пробел сколько угодно чисел: ");
// string[] UserNumbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine(String.Join(" ", UserNumbers));
// int PositiveNumber = 0;
// for (int i=0; i < UserNumbers.Length; i++)
// {
//     if (int.Parse(UserNumbers[i])>0)
//     {
//         PositiveNumber++;
//     }
// }
// Console.WriteLine($"Колличество чисел больше нуля: {PositiveNumber}");

// решение коллег 2
// Console.Clear();
// Console.WriteLine("Сколько чисел вы хотите внести?: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int[size];
// int PositiveNumber = 0;
// for (int i = 0; i < size; i++)
// {   
//     Console.WriteLine($"Введите {i+1}е число: ");
//     Array[i] = Convert.ToInt32(Console.ReadLine());
//     if (Array[i]>0)
//     {
//         PositiveNumber++;
//     }
// }
// Console.Write("Ваш массив: ");
// Console.WriteLine(String.Join(" ", Array));
// Console.WriteLine($"Колличество чисел больше нуля: {PositiveNumber}");

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void ShowArrayAndCount (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//         if (array[i] > 0)
//         {
//             count += 1;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"You've entered {count} positive number(s)");
// }

// Console.WriteLine("How many numbers do You want to input? ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// int[] NumArray = new int[size];

// for (int i = 0; i < size; i++)
// {
//     Console.WriteLine($"Input {i + 1} number: ");
//     NumArray[i] = int.Parse(Console.ReadLine() ?? "0");        
// }

// ShowArrayAndCount(NumArray);

/* решение коллег задачи - Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }
// void InputAndCountNumbers(int number)              // Функция проверки корректности условий
// {
//     if (number > 0)
//     {
//         int[] myArr = ArrayInput(number);
//         ArrayPrint(myArr);
//         System.Console.WriteLine($"Количество положительных чисел равно {PositiveNumber(myArr)}");
//     }
//     else
//     {
//         System.Console.WriteLine("Количество не может быть отрицательным или равным нулю");
//     }
// }
// int[] ArrayInput(int number)                    // Функция ввода массива
// {
//     int[] myArr = new int[number];
//     int i = 0;
//     while (i < number)
//     {
//         Console.Write("Введите число ");
//         myArr[i] = int.Parse(Console.ReadLine());
//         i++;
//     }
//     return myArr;
// }
// int PositiveNumber(int[] myArr)            // Функция подсчета положительных чисел
// {
//     int count = 0;
//     for (int i = 0; i < myArr.Length; i++)
//     {
//         if (myArr[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// void ArrayPrint(int[] myArr)                            // Функция печати массива    
// {
//     for (int j = 0; j < myArr.Length; j++)
//     {
//         System.Console.Write($"{myArr[j]}  ");
//     }
// }
// int number = Prompt("Определите количество чисел для ввода ");  // Определяем количество элементов (М) массива
// InputAndCountNumbers(number);                                 // Начинаем проверку условий



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




// Сгенерировать двумерный массив со случайными числами, вывести его на экран,
// оформить в виде функций (пригодится в дальнейшем)

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0 )         // Функция создания и заполнения двумерного массива случайными числами  
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

int[,] FillArray(int numLine, int numColumns, int maxRand = 20, int minRand = 0 )         // Функция создания и заполнения двумерного массива случайными числами  
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

int numLine = Prompt("Введите количество строк массива ");
int numColumns = Prompt("Введите количество столбцов массива ");
int maxRand = Prompt("Введите верхнюю границу диапазона ");     // Необязательно
int minRand = Prompt("Введите нижнюю границу диапазона ");      // Необязательно    
int[,] matrix = FillArray(numLine, numColumns, maxRand, minRand); // Диапазон значений можно не указывать, будут взяты условия по умолчанию
PrintArray(matrix);


