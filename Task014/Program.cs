/* Напишите программу, которая:
1. Принимает на вход число
2. Проверяет, кратно ли оно квадратом 7 и 23 */

Console.Write("Enter one number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool MultiplicityTwoDigits(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

bool result = MultiplicityTwoDigits(number);

/* Тернарный опператор - сначала лог выражение, далее что писать если True : что писать если False
string resultStr = result ? "Yes" : "No"; // - if result = True -> print YES, else -> print NO  */

/* Более универсальный способ решения задачи:
Console.WriteLine($" {number} --> {resultStr} ");

bool MultiplicityTwoDigits(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}
bool result = MultiplicityTwoDigits(number, 7, 23); */

