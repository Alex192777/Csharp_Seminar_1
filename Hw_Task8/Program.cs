// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


using static System.Console;

int i = 1;
bool not = true;

Clear();
Write ("Введите число:  ");
int a = Convert.ToInt32(ReadLine());
Console.WriteLine("Четные числа от 1 до " + a    );

while(i <= a)
{
    if(i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}
if (not)
{
    Console.Write("Нет четных чисел!");
}
