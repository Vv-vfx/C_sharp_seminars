Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int abs_number = Math.Abs(number);
string string_number = abs_number.ToString();
System.Console.WriteLine($"В числе {number} {string_number.Length} цифр");
