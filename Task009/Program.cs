// Написать программу, которая: 
// 1. выводит случайное число из отрезка [10, 99]  
// 2. показывает наибольшую цифру числа.

// 1.
int number = new Random().Next(10, 100); // Программа для вывода случайного числа
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}");

// 2.
int firstDigit = number / 10; 
int secondDigit = number % 10;

if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit} ");
else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit} ");

// Здесь есть встроенный метод, который определяет наибольшую цифру числа:
Console.WriteLine($"Наибольшая цифра числа --> {Math.Max(firstDigit, secondDigit)} ");

// Далее реализуем задачу с помощью функции (методов)
int MaxDigit(int num) // int num = number (создается копия передаваемого значения)
{
    int firstDigit = num / 10; 
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit; // Если хдесь ложь, то переходим ниже
    return secondDigit; // else здесь не нужен, т.к return прекращает работу метода
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit} ");
