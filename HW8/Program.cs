int[,] GetArray(int m, int n, int min, int max) // Получение массива используется в задачах 54, 56, 58 и 59 ниже
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] array)   // Печать массива - исмользуется в задачах 54, 56, 58 и 59 ниже
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}



/* -----------------------------------------------------------------------------
Задача 54 
Задайте двумерный массив, напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/

/*
void LinesSortedArray(int[,] array)
{
    int[] lineArr = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            lineArr[j] = array[i, j];
        }
        Array.Sort(lineArr);
        Array.Reverse(lineArr);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = lineArr[j];
        }
    }
}

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
LinesSortedArray(array);
PrintArray(array);
*/

/*---------------------------------------------------------------------
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
int MinSumLineSearch(int[,] array)
{
    int minSum = 0;
    int minLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // int maxIndex = i;
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (i == 0) minSum = sum;
        if (sum < minSum)
        {
            minSum = sum;
            minLine = i;
        }
    }
    return minLine;
}

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(string.Format("Наименьшая сумма элементов - в {0} строке (начиная с нулевой)", MinSumLineSearch(array)));
*/

/*-------------------------------------------------------------------------------
Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

/*
int[,] NewMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int k = 0; k < array2.GetLength(1); k++) //6
        {
            int sum = 0;
            for (int j = 0; j < array1.GetLength(1); j++) //6
            {
                sum = sum + array1[i, j] * array2[j, k];
            }
            result[i, k] = sum;
        }
    }
    return result;
}
Console.WriteLine("Введите количество строк массива А: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива А: ");
int columns1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк массива В (для умножения массивов должно быть равно количеству столбцов массива А): ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива В: ");
int columns2 = int.Parse(Console.ReadLine()!);

if (columns1 != rows2)
    Console.WriteLine("Такие массивы нельзя перемножить");
else
{
    int[,] array1 = GetArray(rows1, columns1, 0, 10);
    int[,] array2 = GetArray(rows2, columns2, 0, 10);
    Console.WriteLine("Массив А:");
    PrintArray(array1);
    Console.WriteLine("Массив В:");
    PrintArray(array2);
    int[,] NewArray = NewMatrix(array1, array2);
    Console.WriteLine("Массив АхВ:");
    PrintArray(NewArray);
}
*/

/*----------------------------------------------------------------------------
Задача 59: Отсортировать нечетные столбцы массива по возрастанию. 
Вывести массив изначальный и массив с отсортированными нечетными столбцами
*/

void ColumnsSortedArray(int[,] array)
{
    int[] columnArr = new int[array.GetLength(0)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j % 2 != 0)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                columnArr[i] = array[i, j];
            }
            Array.Sort(columnArr);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, j] = columnArr[i];
            }
        }
    }
}

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
ColumnsSortedArray(array);
Console.WriteLine("Массив с отсортированными нечетными столбцами");
PrintArray(array);
Console.WriteLine();


/* ---------------------------------------------------------------------------
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
  которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/
/*
 //формируем одномерный массив, из которого будет сформирован трехмерный.
void Form1Darr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        bool k = true;
        while (k)
        {
            arr[i] = new Random().Next(10, 100);
            if (i > 0) k = Proverka(arr, arr[i], i);
            else k = false;
        }
    }
}

//Проверка элементов на совпадение
bool Proverka(int[] arr, int n, int i)
{
    if (i > 0)
    {
        if (n == arr[i - 1]) return true;
        else return Proverka(arr, n, i - 1);
    }
    else
        return false;
}
//Заполнение трехмерного массива
int[,,] Massiv3D(int[] arr, int m, int n, int o)
{
    int[,,] array3d = new int[m, n, o];
    int count = 0;
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int k = 0; k < o; k++)
            {
                array3d[i, j, k] = arr[count];
                count += 1;
            }
    return array3d;
}
//Печать 3D массива
void Print3D(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($" {arr3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
}

Console.Clear();
Console.Write("Введите 1-ю размерность массива (m): ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ю размерность массива (n): ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ю размерность массива (o): ");
int o = int.Parse(Console.ReadLine()!);

int[] arr = new int[m * n * o];
Form1Darr(arr);
Console.WriteLine();
int[,,] arr3D = Massiv3D(arr, m, n, o);
Print3D(arr3D);
Console.WriteLine();
*/

/*--------------------------------------------------------------------------------------
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

/*
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,4} ", arr[i, j]));
        }
        Console.WriteLine();
    }
}


void Recurse(int[,] arr, int x, int y, int upX, int upY, int downX, int downY, int count, string dir)
{

    if (count <= arr.Length)
    {
        arr[x, y] = count;
        count = count + 1;
        switch (dir)
        {
            case "right":
                {
                    y = y + 1;
                    if (y == upY)
                    {
                        dir = "down";
                        upY = upY - 1;
                    }
                    break;
                }
            case "down":
                {
                    x = x + 1;
                    if (x == upX)
                    {
                        dir = "left";
                        upX = upX - 1;
                    }
                    break;
                }
            case "left":
                {
                    y = y - 1;
                    if (y == downY)
                    {
                        dir = "up";
                        downY = downY + 1;
                    }
                    break;
                }
            case "up":
                {
                    x = x - 1;
                    if (x == downX)
                    {
                        dir = "right";
                        downX = downX + 1;
                    }
                    break;
                }
        }
        Recurse(arr, x, y, upX, upY, downX, downY, count, dir);
    }
}
Console.Write(" Введите количество строк массива : ");
Console.WriteLine();

Console.Write(" Введите количество cтолбцов массива > 1: ");
Console.WriteLine();


int n = 7;
int m = 7;
int[,] arr = new int[n, m];
int x = 0;
int y = 0;
int upX = n - 1;
int upY = m - 1;
int count = 1;
string dir = "right";
int downX = 1;
int downY = 0;
Recurse(arr, x, y, upX, upY, downX, downY, count, dir);
Print(arr);
*/