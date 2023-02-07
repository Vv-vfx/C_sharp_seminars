// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int res = (a / 10) % 10;

System.Console.WriteLine(res);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
a = Math.Abs(a);
Console.WriteLine(a>99 ? a.ToString()[2] : "Нет третьей цифры ");

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a == 6 || a == 7) System.Console.WriteLine("Выходной");
if (a > 7 || a < 1) System.Console.WriteLine("Нет такого дня недели");
else System.Console.WriteLine("Не выходной");