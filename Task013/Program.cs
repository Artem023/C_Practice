/* Напишите программу, которая 
1. Выводит третью цифру заданного числа или сообщает, что третьей цифры нет. */

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int ThirdDigit (int num)
{
    while (num > 1000) num = num / 10;
    return num = num % 10;
}

if (number > 99)
{
    int result = ThirdDigit(number);
    Console.WriteLine($"Third digit of {number} is {result} ");
}
else Console.WriteLine("Third digit doesn't exist");