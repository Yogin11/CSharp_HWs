/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

//          Вариант 1
// Console.Write("Введите количество чисел (М): ");
// int m = int.Parse(Console.ReadLine());
// 
// int n = 0;
// for (int i = 1; i <=m; i++)
// {
// Console.Write($"Введите {i}-е число: ");
// int k = Convert.ToInt32(Console.ReadLine());
// if (k>0) n++;
// }
// Console.WriteLine($"Количество чисел больше нуля равно: {n}");

//           Вариант 2
// Console.Clear();
// string enter = " ";
// int n = 0;
// while (enter != "s" && enter != "S")
// {
// Console.Write($"Введите число. (Чтобы прекратить ввод чисел, наберите S): ");
// string k = Console.ReadLine()!;
// bool ddd = double.TryParse(k, out double d);
// if (ddd)
// {if (d < 0) n++;}
// else enter = k;
// }
// Console.WriteLine();
// Console.WriteLine($"Количество чисел меньше нуля: {n}");
// Console.WriteLine();

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
Console.WriteLine("Даны уравнения прямых: y = k1 * x + b1 и y = k2 * x + b2");
Console.Write("введите коэффицент k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("введите коэффицент b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("введите коэффицент k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("введите коэффицент b2: ");
double b2 = double.Parse(Console.ReadLine()!);
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine();
Console.WriteLine($"Координаты точки пересечения прямых: ({x:f2} ; {y:f2})");
Console.WriteLine();
