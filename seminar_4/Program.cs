// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int degree  = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= degree; i++)
{   
    result *= number;

}
System.Console.WriteLine($"{number}  в степени {degree} = {result}");

// =====================================================
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
char[] string_number = Console.ReadLine().ToCharArray();
int[] int_number = Array.ConvertAll(string_number, s => (int)Char.GetNumericValue(s));
System.Console.WriteLine(int_number.Sum());

// =====================================================

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите числа через пробел: ");
int[] string_number = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
System.Console.WriteLine(string.Join(',', string_number));
System.Console.WriteLine($"string_number type in {string_number.GetType()}");