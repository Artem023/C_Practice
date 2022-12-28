/* Задайте значение М и N
Напишите программу, которая
выдаст натуральные числа от M до N */

Console.Write("Введети натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введети натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num1, int num2)
{
    if (num1 == num2) Console.Write($"{num1}, ");
    if (num1 > num2)
    {
        Console.Write($"{num1}, ");
        NaturalNumbers(num1 - 1, num2);
    } 
    else if (num1 < num2)
    {
        Console.Write($"{num1}, ");
        NaturalNumbers(num1 + 1, num2);
    }
}

NaturalNumbers(m, n);
