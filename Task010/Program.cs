/* Напишите программу, которая 
1. Принимает на вход трёхзначное число 
2. На выходе показывает вторую цифру этого числа. 456 -> 5 */

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit (int num)
{
    int res = num / 10;
    return res = res % 10;
}

if (number > 99 && number < 1000)
{
    int result = SecondDigit(number);
    Console.WriteLine($"Second digit of {number} is {result} ");
}
else Console.WriteLine("You enter wrong number");