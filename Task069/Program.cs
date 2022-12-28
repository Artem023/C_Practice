/* Напишите программу, которая
на вход приинимает два числа А и В
возводит число А в степень В */

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Square (int number1, int number2)
{
    if (number2 == 0) return number1;
    return number1 * Square(number1, number2 - 1);
}

int result = Square(num1, num2);
Console.WriteLine(result);