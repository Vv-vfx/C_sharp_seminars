// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень: ");
// int degree  = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= degree; i++)
// {   
//     result *= number;

// }
// System.Console.WriteLine($"{number}  в степени {degree} = {result}");

// =====================================================
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число: ");
// char[] string_number = Console.ReadLine().ToCharArray();
// int[] int_number = Array.ConvertAll(string_number, s => (int)Char.GetNumericValue(s));
// System.Console.WriteLine(int_number.Sum());

// =====================================================

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите числа через пробел: ");
int[] string_number = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
System.Console.WriteLine(string.Join(',', string_number));
System.Console.WriteLine($"string_number type in {string_number.GetType()}");

// int[] int_number = Array.ConvertAll(string_number, s => (int)Char.GetNumericValue(s));
// System.Console.WriteLine(int_number.Sum());


















// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int abs_number = Math.Abs(number);
// string string_number = abs_number.ToString();
// char[] arr = string_number.ToCharArray();
// System.Console.WriteLine($"В числе {number} {arr.Length} цифр");

// ==============================================

// System.Console.WriteLine("ВВедите количество элементов массива");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[n];

// void FillArray(int[] collection)

// {   
//     int index = 0;
//     while (index < collection.Length)
//     {
//         collection[index] = new Random().Next(0,2);
//         index++;
//     }
// }

// FillArray(array);
// System.Console.WriteLine(string.Join(" ", array));

// System.Console.WriteLine("Введите числа через пробел");
// string [] strArray = Console.ReadLine().Split(" ");

// Console.WriteLine("Введите числа через пробел: ");
// string[] string_number = Console.ReadLine().Split();
// int[] int_numbers = Array.ConvertAll(string_number, s => int.Parse(s));
// System.Console.WriteLine(int_numbers.GetType());


// Console.WriteLine("Введите числа через пробел: ");
// string[] string_number = Console.ReadLine().Split();
// int[] int_numbers = Array.ConvertAll(string_number, int.Parse);
// System.Console.WriteLine(int_numbers.GetType());

// int[] ints = Array.ConvertAll(strings, int.Parse);
// Console.WriteLine(String.Join(",", ints));

// int[] arr = {1,5,3,8,6,2,9,0};
// System.Console.WriteLine(string.Join(" ", arr));