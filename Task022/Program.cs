/* Написать программу, которая: 
1. принимает на вход число (N) и 
2. выдает таблицу квадратов числа от 1 до N */

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int num) // void используется тогда, когда нам не нужно ничего возвращать
{
    int num1 = 1;
    while (num1 <= num)
    {
        int result = num1 * num1;
        Console.WriteLine($"{num1, 15} ---> {result} "); // {num1, отступ (длинна строки)}
        num1++;
    }
}
if (number > 0)
{
    Square(number);
}
else Console.WriteLine("ERROR");