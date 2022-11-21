/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int NewNumber(num)
{
    int num5 = num % 10; //num5 * 10000
    int num4 = num / 10 % 10; // num4 * 1000 + num5
    int num3 = num / 100 % 10; // num3 * 100 + num4
    int num2 = num / 1000 % 10; // num2 * 10 + num3
    int num1 = num / 10000;
    res = num5 * 10000 
        + num4 * 1000 
        + num3 * 100 
        + num2 * 10
        + num1
}

if (number > 9999 && number < 100000)
{
    int result = NewNumber(number);
    if (result == number)
    { 
    Console.WriteLine($"{number} --> Yes");
    }
    else Console.WriteLine($ {number} --> "No");
}
else Console.WriteLine("WRONG NUMBER");