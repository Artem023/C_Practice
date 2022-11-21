// Напишите программу, которая:
// 1. Выводит рандомное трехзначное число
// 2. Удаляет вторую цифру этого числа

int number = new Random().Next(99, 1000);
Console.WriteLine(number);

int DelNum(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

int res = DelNum(number);
Console.WriteLine($"Новое число --> {res}");