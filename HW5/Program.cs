/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
// int[] GetArray(int size)
// {
    // int[] arr = new int[size];
    // for (int i = 0; i < arr.Length; i++)
    // {
        // arr[i] = new Random().Next(100,999);
    // }
    // return arr;
// }
// int evenNum(int[] arrEve)
// {   
    // int k = 0;
    // for (int i = 0; i < arrEve.Length; i++)
    // {
        // if (arrEve[i]%2==0) k++;
    // }
    // return k;
// }
// Console.WriteLine("Введите размер массива: ");
// int[] y = GetArray(int.Parse(Console.ReadLine()!));
// Console.WriteLine("Заданный массив: ");
// Console.WriteLine($"    [{String.Join(' ',y)}] ");
// Console.WriteLine($"Количество четных элементов: {String.Join(',',evenNum(y))} ");

/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// int[] GetArray(int size)
// {
    // int[] arr = new int[size];
    // for (int i = 0; i < arr.Length; i++)
    // {
        // arr[i] = new Random().Next(-100,100);
    // }
    // return arr;
// }
// int OddPositionSum(int[] arrOdd)
// {   
    // int sum = 0;
    // for (int i = 0; i < arrOdd.Length; i++)
    // {
        // if (i%2!=0) sum += arrOdd[i];
    // }
    // return sum;
// }
// Console.Clear();
// Console.WriteLine("Введите размер массива: ");
// int[] y = GetArray(int.Parse(Console.ReadLine()!));
// Console.WriteLine("Заданный массив: ");
// Console.WriteLine($"    [{String.Join(' ',y)}] ");
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {OddPositionSum(y)} ");
// 

/*
Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности,
 с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }
    return arr;
}

int maxElement(int[] arr)
{   
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]> max) max = arr[i];
    }
    return max;
}

int minElement(int[] arr)
{   
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]< min) min = arr[i];
    }
    return min;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] y = GetArray(int.Parse(Console.ReadLine()!));
Console.WriteLine("Заданный массив: ");
Console.WriteLine($"    [{String.Join(' ',y)}] ");
Console.WriteLine($"Разница между максимальным и минимальным элементом {maxElement(y)-minElement(y)}"); 
