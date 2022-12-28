/* Задайте значение N
Напишите программу, которая
выведет все натуральные числа 
в промежутке от 1 до N */

Console.Write("Введети натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers( int num)
{
    if (num == 0) return; 
    NaturalNumbers (num - 1); // Рекурсивный вызов метода 
    Console.Write($"{num}, "); // Выполняется в самом конце (когда доходит до 0)
}

NaturalNumbers(number);
