// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write ("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write($"Max number is {num1}. ");
    Console.Write($"Min number is {num2}. ");
}
else
{
    Console.Write($"Max number is {num2}. ");
    Console.Write($"Min number is {num1}. ");
}
