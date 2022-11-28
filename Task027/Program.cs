/* Напишите программу, которая 
1. принимает на вход число 
2. выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
    
int SumDigits (int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}
if (number >= 0)
{    
    int result = SumDigits(number);
    Console.Write($"{number} -> {result} ");
}
else Console.Write("Change your number");