/* Напишите программу, которая
1. Принимает число (А)
2. Выдает сумму чисел от 1 до А */

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
    sum = sum + i;
    }
    return sum;
}

if (number > 0)
{
int sumnumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumnumbers}");
}
else Console.WriteLine("ERROR");