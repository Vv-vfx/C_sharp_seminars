Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
char[] arr = a.ToCharArray();
Array.Reverse(arr);
string new_a = new string(arr);   //здесь вопрос
if (a == new_a) System.Console.WriteLine("Полиндром");
else System.Console.WriteLine("Не Полиндром");





