﻿/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

/*
string RecursDown (int N)
{
    if (N == 1) return "1";
    return N.ToString() + "," + RecursDown(N-1).ToString(); 
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Все натуральные числа от {N} до 1: {RecursDown(N)}");
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int RecursSum(int M, int N)
{
    if (M == N) return N;
    return M + RecursSum(M + 1, N);
}
Console.WriteLine("Введите натуральное число М (нижнюю границу)");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуральное число N (верхнюю границу)");
int N = int.Parse(Console.ReadLine()!);
if (M > N)
    Console.WriteLine("неверные данные  -> M должно быть меньше N");
else
    Console.WriteLine($"Сумма элементов от {M} до {N} = {RecursSum(M, N)}");
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
double AkkermanF(double M, double N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return AkkermanF(M - 1, 1);
    return AkkermanF(M - 1, AkkermanF(M, N - 1));
}

Console.WriteLine("Введите неотрицательное число М ");
double M = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите неотрицательное число N ");
double N = double.Parse(Console.ReadLine()!);
if (M < 0 || N < 0)
    Console.WriteLine("необходимо ввести неотрицательные числа");
else
    Console.WriteLine($"результат функции Аккермана A({M},{N}) = {AkkermanF(M, N)}");