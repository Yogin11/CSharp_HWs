/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
// Console.Clear();
// Console.Write("Введите размерность массива m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите размерность массива n: ");
// int n = int.Parse(Console.ReadLine()!);
// double[,] massiv = new double[m,n];
// Console.WriteLine();
// Console.WriteLine("Полученный массив c вещественными числами: ");
// FillPrintArray(m,n);
// Console.WriteLine();
// void FillPrintArray(int m, int n)
// {
    // for (int i = 0; i < m ; i++)
    // {
        // for (int j = 0; j < n; j++)
        // {
            // massiv[i,j] = new Random().NextDouble()* new Random().Next(-10,10);
            // Console.Write(string.Format("{0,10:f1}", massiv[i,j]));
        // }
        // Console.WriteLine();
    // }
// }
// 
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2
*/
// Console.Clear();
// Console.Write(" Введите номер строки элемента массива: ");
// int i = int.Parse(Console.ReadLine()!);
// Console.Write(" Введите номер столбца элемента массива: ");
// int j = int.Parse(Console.ReadLine()!);
// Console.WriteLine(" Заданный массив: ");
// 
// int[,] massiv = new int[5,5];
// FillArray(5,5);
// Console.WriteLine();
// CheckNumber(massiv, i , j);
// 
// void FillArray(int m, int n){
    // for (int i = 0; i < m ; i++) 
    // {
        // for (int j = 0; j < n; j++) {
            // massiv[i,j] = new Random().Next(0,10);
            // Console.Write(string.Format("{0,2}", massiv[i,j]));
        // }
        // Console.WriteLine();
    // }
// }
// 
// void CheckNumber(int[,] arr, int i, int j)
// {   
    // if (arr.GetLength(0)-1 < i || arr.GetLength(1)-1 < j )
        // Console.WriteLine($" i = {i}, j = {j}  -> такого числа в массиве нет ");
    // else        
        // Console.WriteLine($"  i = {i}, j = {j} -> искомое число: {arr[i,j]}  "  );
// }

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();
Console.Write("Введите размерность массива m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность массива n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] massiv = new int[m,n];
FillArray(m,n);
double[] mean = ArithMean(massiv);
Console.Write("Cреднее арифметическое каждого столбца: ");
Console.WriteLine(String.Join("; ", mean) );

void FillArray(int m, int n)
{
    for (int i = 0; i < m ; i++) 
    {
        for (int j = 0; j < n; j++) {
            massiv[i,j] = new Random().Next(0,10);
            Console.Write(string.Format("{0,2}", massiv[i,j]));
        }
        Console.WriteLine();
    }
}

double[] ArithMean(int[,] arr)
{   
    double[] arith = new double[arr.GetLength(1)];  
    for (int j = 0; j < arr.GetLength(1); j++)
    {   
       double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i,j]; 
        }
    arith[j] = Math.Round(sum/arr.GetLength(1),1);    
    }
    return arith;
}
