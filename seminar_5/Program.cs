
// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[10];

void FillArray(int[] collection)

{   Random rnd = new Random();
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = rnd.Next(100,1000);
        index++;
    }
}

FillArray(arr);
Console.WriteLine(string.Join(' ', arr));

int[] arrFindElements = Array.FindAll(arr, x => x % 2 == 0);
Console.WriteLine($"Чётные числа {string.Join(' ', arrFindElements)}");
Console.WriteLine($"Количество чётных чисел {arrFindElements.Length}");
 
// ========================================

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[10];

void FillArray(int[] collection)

{   Random rnd = new Random(123);
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = rnd.Next(1,10);
        index++;
    }
}

FillArray(arr);
Console.WriteLine(string.Join(' ', arr));

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 0) continue;
    
    else {
        sum += arr[i];
        System.Console.WriteLine(arr[i]);
    }
}

System.Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");

// =====================================

// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] arr = new int[10];

void FillArray(int[] collection)

{   Random rnd = new Random(234);
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = rnd.Next(1,20);
        index++;
    }
}

FillArray(arr);
Console.WriteLine(string.Join(' ', arr));

int max;
int min;

if (arr[0] > arr[0] || arr[0] == arr[0] )
{
    max = arr[0];
    min = arr[1];
} 
else
{
    max = arr[1];
    min = arr[0];
} 

for (int index = 2; index < arr.Length; index++)
{
    if (arr[index] > max) max = arr[index];
    else if (arr[index] < min) min = arr[index];
}

Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {max - min}");