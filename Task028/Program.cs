/* Напишите программу, которая:
1. принимает на вход число N
2. выдает произведение чисел от 1 до N */

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int MultNumbers (int num)
{
   int mult = 1;
   for (int i = 1; i <= num; i++)
   {
   mult = mult * i;
   }
   return mult;
}

if (number > 0)
{
int result = MultNumbers(number);
Console.WriteLine($"Произведение число от 1 до {number} = {result}");
}
else Console.WriteLine("Требуется ввести натерально число");