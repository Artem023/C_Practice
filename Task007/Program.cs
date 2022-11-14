Console.WriteLine("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);

if (N < 1000 && N > 99 )
{
    N = N % 10;
    Console.Write(N);
}
else Console.WriteLine("Трехзначное число");



