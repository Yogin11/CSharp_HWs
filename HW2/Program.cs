﻿/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным. Обязательно сделать проверку на ввод чисел меньше 1 и больше 7

6 -> да
7 -> да
1 -> нет

*/

int g = 0;
Console.WriteLine("Введите номер дня недели");
while (g == 0)  
{ 
    int a = int.Parse(Console.ReadLine()!);
    if (a >=1  &&  a <= 7) 
    {
        g = 1;
        if (a == 6 || a == 7) Console.WriteLine (" Выходной");
        else Console.WriteLine (" Нет, не выходной ");
    }
    else Console.WriteLine(" Введите номер дня недели от одного до семи ");
}






