// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число: ");
int A=Convert.ToInt32(Console.ReadLine());
int B=Convert.ToInt32(Console.ReadLine());
if (A < B)
{
    Console.Write ("Второе число MAX, первое число MIN");
}
else
{
    Console.Write ("Первое число MAX, второе число MIN");
}  

