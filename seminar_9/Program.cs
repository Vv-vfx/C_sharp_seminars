
// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string GetNaturalNumbers(int N)

{
    if (N == 1) return "1";
    return N.ToString() + " " + GetNaturalNumbers(N - 1) ;

}


Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа {GetNaturalNumbers(N)}");

// =======================================

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumm(int M, int N)

{
    if (M == N) return M;
    return M + GetSumm(M + 1, N) ;

}

Console.WriteLine("Введите от какого числа: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите до какого числа: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от {M} до {N} = {GetSumm(M, N)}");

// =======================================



// https://qarchive.ru/926689_printsip_dei_stvija_akkermana

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ankerman(int m, int n)

{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ankerman(m - 1, 1);
    else return Ankerman(m - 1, Ankerman(m, n - 1));  //(m > 0 && n > 0)
        
}

Console.WriteLine("Ankerman(m, n)");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{Ankerman(m, n)}");


