// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисе

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Clear();

Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int c = Convert.ToInt32(Console.ReadLine());

int max1 = Math.Max(a, b);
int max = Math.Max(max1, c);
System.Console.WriteLine($"Максимальное {max}");