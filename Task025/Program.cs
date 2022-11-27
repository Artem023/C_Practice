/* Напишите цикл, который 
1. принимает на вход два числа (A и B) 
2. возводит число A в натуральную степень B.
3, 5 -> 243
2, 4 -> 16 */

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void NumberDegree(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i ++)
    {
        result = result * number1;
    }
    Console.Write($"The number {number1} to the power of the number {number2} is {result} ");
}

if (num2 > 0 && num1 > 0)
{
NumberDegree(num1, num2);
}
else Console.WriteLine("You enter wrong number");