/* Написать программу, которая
1. принимает число
2. выдает количество цифр в числе */

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountDigits(int num)
{
    int digit = 0;    
    while (num != 0)
    {
        num = num / 10;
        digit++;
    }
    return digit == 0 ? 1 : digit;    
}

int countdigits = CountDigits(number);
Console.WriteLine($"{number} -> {countdigits}");