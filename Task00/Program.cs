// Написать программу, которая:
    // 1. Принимает число
    // 2. Выдает его квадрат

Console.WriteLine("Enter integer number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int square = numberA * numberA;
Console.WriteLine ($"Квадрат числа {numberA} = {square}");