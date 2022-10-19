/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите количество чисел (М): ");
int m = int.Parse(Console.ReadLine());

int n = 0;
for (int i = 1; i <=m; i++)
{
    Console.Write($"Введите {i}-е число: ");
    int k = Convert.ToInt32(Console.ReadLine());
    if (k>0) n++;
}
Console.WriteLine($"Количество чисел больше нуля равно: {n}");
