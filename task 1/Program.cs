// // Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

Console.Clear();

System.Console.WriteLine("Введите a");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите b");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b){
    Console.WriteLine($"max = {a} min = {b}");
}
if (a == b){
    Console.WriteLine($"Числа a и b равны {a}");
}
else
{
    Console.WriteLine($"max = {b} min = {a}");
}
