/* Написать программу, которая:
1. Получает на вход два числа
2. Проверяет, является ли первое число квадратом второго */

Console.Write("Enter two numbers: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

bool Square(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1; // || - или
}

bool result = Square(number1, number2);
Console.WriteLine(result ? "Yes" : "No");