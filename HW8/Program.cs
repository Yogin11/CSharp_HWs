/* ДЗ№ 8 
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
  которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/
// формируем одномерный массив, из которого будет сформирован трехмерный.
void Form1darr(int[] arr)
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

// Проверка элементов на совпадение
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
Form1darr(arr);
Console.WriteLine();
int[,,] arr3D = Massiv3D(arr, m, n, o);
Print3D(arr3D);
Console.WriteLine();
