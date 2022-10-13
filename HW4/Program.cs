/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// int Exponen(int a, int b)
	// {	int d = a;
		// for (int i = 1; i < Math.Abs(b) ; i++)
		// {	
			//  a = d * a;
		// }
		// return a;
	// }
	// Console.Write("Введите число А: ");
	// int A = int.Parse(Console.ReadLine()!);
	// Console.Write("Введите натуральное число B: ");
	// int B = int.Parse(Console.ReadLine()!);
    // if (B<=0) Console.WriteLine("Вы ввели не натуральное число!");
    // else Console.WriteLine($"Число {A} в степени {B} равно  {Exponen(A, B)}");
// 

/* 
Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
// int SumDigits(int a)
		// {	
			// int sum = 0;
			// do
			// {
				// sum +=a%10;
				// a=a/10;
			// }
			// while (a!=0);
		// return Math.Abs(sum);
		// }
	// Console.Write("Введите число А: ");
    // int A = int.Parse(Console.ReadLine()!);
	// Console.WriteLine($"Сумма цифр в числе {A} равно {SumDigits(A)}");


/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
using System;
	void FillArray(int[] arr)
		{	
			for (int i =0; i < arr.Length; i++)
			{
				arr[i] = new Random().Next(-300,300);
			}
		}
	int[] array = new int[8];	
	FillArray(array);
    Console.Clear();
    Console.Write($"[{String.Join(',', array)}]\n");
    Console.WriteLine();


