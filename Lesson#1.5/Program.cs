// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456->6 782->2 918->8

Console.WriteLine("Введите трехзначное число");
int N = Math.Abs(int.Parse(Console.ReadLine()));
if (N > 99 && N < 1000)
{
    int res = N % 10;
    Console.Write(res);
}
else
{
    Console.WriteLine("Число не трехзначное");
}