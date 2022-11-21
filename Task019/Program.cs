/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

//Вариант решения №1.
/* bool Palindrom1(int num)
{
    int num5 = num % 10; 
    int num4 = num / 10 % 10; 
    int num3 = num / 100 % 10; 
    int num2 = num / 1000 % 10; 
    int num1 = num / 10000;
    return num5 * 10000
        + num4 * 1000
        + num3 * 100
        + num2 * 10
        + num1 == num;
} */

//Вариант решения №2 (сравнение первых и последних двух чисел)
bool Palindrom2(int num)
{
    return num / 10000 == num % 10 && num /1000 % 10 == num % 100 / 10;
}
if (number > 9999 && number < 100000)
{
    bool result = Palindrom2(number);
    Console.Write($"{number} --> ");
    Console.WriteLine(result ? "Yes" : "No"); // Можно ли как-то строчку №27 записать в строчку №28???
}
else Console.WriteLine("WRONG NUMBER");

