// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
char[] arr = a.ToCharArray();
Array.Reverse(arr);
string new_a = new string(arr);  
if (a == new_a) System.Console.WriteLine("Полиндром");
else System.Console.WriteLine("Не Полиндром");

// =====================================================

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        System.Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            System.Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    
    return result;
}

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
    System.Console.WriteLine(distance);
    return distance;
}

int x1 = GetNumber("Введите координату X для первой точки");
int y1 = GetNumber("Введите координату Y для первой точки");
int z1 = GetNumber("Введите координату Z для первой точки");
int x2 = GetNumber("Введите координату X для второй точки");
int y2 = GetNumber("Введите координату Y для второй точки");
int z2 = GetNumber("Введите координату Z для второй точки");




double distance = GetDistance(x1, y1, z1, x2, y2, z2);

System.Console.WriteLine($"Расстояние между точками в 3D пространстве равно {distance}");


// ============================================================

// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNumber(string message)
{
    int result = 0;

    while(true)
    {
        System.Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            System.Console.WriteLine("Введите число");
        }
    }
    
    return result;
}

void CalcCube(int n)
{
    for (int i = 1; i <= n; i++)
    {
        System.Console.WriteLine($"Квадрат числа {i} = {Math.Pow(i,3)}");
    }
}

int n = InputNumber("Введите число больше 1");
CalcCube(n);
