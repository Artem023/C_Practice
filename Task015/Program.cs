/* Напишите программу, которая: 
1. Принимает на вход цифру, обозначающую день недели
2. Проверяет, является ли этот день выходным. */

Console.Write("Enter day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

bool DayOfWeek(int num)
{
    return num == 6 || num == 7; 
}

if (number >= 1 && number < 8)
{
bool result = DayOfWeek(number);
Console.WriteLine(result ? "Yes" : "No");
}
else Console.WriteLine($"This ({number}) day of the week doesn't exist");