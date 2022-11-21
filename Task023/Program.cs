/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125 */

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

void Cube(int number)
{
    Console.WriteLine($"{number} ->");
    int number1 = 1;
    while (number1 <= number)
    {
        int result = number1 * number1 * number1;
        Console.Write($"{number1} | ");
        Console.WriteLine(result);
        number1 ++;
    }
    
}
if (num > 0)
{
    Cube(num); 
}
else Console.WriteLine("ERROR");