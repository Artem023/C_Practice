// Задача 66: Задайте значения M и N. 
// Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Enter M value: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N value: ");
int n = Convert.ToInt32(Console.ReadLine());

int ElementsSum(int num1, int num2)
{
    if (num1 == num2) return num1;
    if (num1 < num2)
    {
        return num1 + ElementsSum(num1 + 1, num2);
    }
    else return num2 + ElementsSum(num1, num2 + 1);
}

int result = ElementsSum(m, n);
Console.Write($"M = {m}; N = {n} -> {result}");
