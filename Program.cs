//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();				                // очистка консоли

Console.WriteLine("Введите 1-е число: ");		// ввод 1-го числа
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е число: ");		// ввод 2-го числа
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3-е число: ");		// ввод 3-го числа
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if (n2 > max)
    max = n2;
if (n3 > max)     
    max = n3;
Console.WriteLine($"Максимальное число: {max}.");