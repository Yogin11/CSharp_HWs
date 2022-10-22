/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.Clear();
Console.Write("Введите размерность массива m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность массива n: ");
int n = int.Parse(Console.ReadLine()!);
double[,] massiv = new double[m,n];
Console.WriteLine();
Console.WriteLine("Полученный массив c вещественными числами: ");
FillPrintArray(m,n);
Console.WriteLine();
void FillPrintArray(int m, int n)
{
    for (int i = 0; i < m ; i++)
    {
        for (int j = 0; j < n; j++)
        {
            massiv[i,j] = new Random().NextDouble()* new Random().Next(-10,10);
            Console.Write(string.Format("{0,10:f1}", massiv[i,j]));
        }
        Console.WriteLine();
    }
}







