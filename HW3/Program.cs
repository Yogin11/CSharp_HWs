/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)

14212 -> нет
12821 -> да
23432 -> да
*/
//Вариант 1 (Математически)
// bool g = true;
// while (g)
// {
// Console.WriteLine("Введите пятизначное число");
// int x = int.Parse(Console.ReadLine()!);
// if (x / 100000 < 1 & x / 10000 >= 1)
// {
// g = false;
// if ((x % 10 == x / 10000 % 10) & (x /10 % 10 == x / 1000 % 10)) 
// Console.WriteLine("Число - палиндром");
// else Console.WriteLine("Число не палиндром");
// }
// else Console.WriteLine("Вы ввели не пятизначное число, ");
// }

// Вариант 2 (Строковый)
// bool g = true;
// int n = 0;
// while (g)
// {
// Console.WriteLine("Введите пятизначное число");
// string x = Console.ReadLine()!;
// if (x.Length == 5)
// {
// g = false;
// for (int i = 0; i < (x.Length) / 2; i++)
// if (x[i] == x[x.Length - 1 - i]) n++;
// if (n == (x.Length) / 2) Console.WriteLine("Число палиндром ");
// else Console.WriteLine("Число не палиндром");
// }
// else Console.WriteLine("Вы ввели не пятизначное число, ");
// }

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// int A = 0;
// int B = 0;
// double S = 0;
// for (int i = 0; i < 3; i++)
// {
// Console.Write($"Введите {i + 1}-ю координату точки A: ");
// A = int.Parse(Console.ReadLine()!);
// Console.Write($"Введите {i + 1}-ю координату точки B: ");
// B = int.Parse(Console.ReadLine()!);
// S = S + Math.Pow(A - B, 2);
// Console.WriteLine();
// }
// S = Math.Sqrt(S);
// Console.WriteLine($"Расстояние между ними = {S:f2} \n");

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++)
    Console.Write($"{Math.Pow(i, 3)}\t");




