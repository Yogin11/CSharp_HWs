﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
// {
// Console.WriteLine("число A больше, A = " + a);
// }
// else
// {
// Console.WriteLine("число B больше, B = " + b);
// }

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (b > max  & b > c ) { 
    max = b;
} 
else if (c > max & c > b) { 
    max = c; 
}
Console.WriteLine ("Максимум равен " + max);