Console.WriteLine("Enter natural number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = number1 * (-1);

if (number1 <= 0)
{
    Console.Write("ERROR");
}
else Console.Write($"{number2},");
{
    while (number2 < number1)
    {
        number2 = number2 + 1;
        Console.Write($"{number2},");
    }
}
