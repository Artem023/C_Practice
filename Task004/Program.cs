// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter fird number: ");
int  n3 = Convert.ToInt32(Console.ReadLine());
int nmax = n1;

// Решение №1 (метод гирек)
if (n1 > n2)
{
    nmax = n1;
}
else nmax = n2;

if (n1 > n3)
{
    nmax = n1;
}
else nmax = n3;

if (n2 > n3)
{
    nmax = n2;
}
else nmax = n3;

// Решение №2 (мой метод)
if (n1 > n2)
{
    nmax = n1;
}
else 
{
    nmax = n2;
}
if (nmax > n3)
{
    Console.WriteLine();
}
else nmax = n3;

Console.WriteLine($"Max = {nmax} ");


