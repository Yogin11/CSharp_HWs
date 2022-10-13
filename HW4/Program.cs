/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int Exponen(int a, int b)
	{	int d = a;
		for (int i = 1; i < Math.Abs(b) ; i++)
		{	
			 a = d * a;
		}
		return a;
	}
	Console.Write("Введите число А: ");
	int A = int.Parse(Console.ReadLine()!);
	Console.Write("Введите натуральное число B: ");
	int B = int.Parse(Console.ReadLine()!);
    if (B<=0) Console.WriteLine("Вы ввели не натуральное число!");
    else Console.WriteLine($"Число {A} в степени {B} равно  {Exponen(A, B)}");
