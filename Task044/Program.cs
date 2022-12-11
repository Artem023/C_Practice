/* Не используя рекурсию
выведите первые N чисел Фибоначчи.
Первые два числа 0 и 1 */

/* Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Fibonacci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 0; i < 45; i++)
{
    Console.WriteLine($"f({i}) - {Fibonacci(i)}");
} */

int[] Fibonacci(int num)
{
    int [] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array [i] = array [i - 1] + array [i - 2];
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int [] arr = Fibonacci(7);
PrintArray(arr);
