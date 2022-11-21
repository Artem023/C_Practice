// Написать программу, которая:
// 1. На вход принимает два числа
// 2. Является ли первое число кратно второму

Console.WriteLine("Enter two numbers: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int TaskSol(int num1, int num2)
{
    int result = num1 % num2;
    return result;
}

int res = TaskSol(number1, number2);
if (res == 0)
{
    Console.WriteLine("Число кратно");
}
else Console.WriteLine($"Не кратно, остаток {res} ");