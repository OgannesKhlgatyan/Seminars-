// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int N = int.Parse(Console.ReadLine());
int result = GetSummChars(N);
Console.WriteLine(result);

int GetSummChars(int N)
{
    int i;
    int summ = 0;
    for (i = 0; N != 0; i++)
    {
        summ = N % 10 + summ;
        N = N / 10;
    }
    return Math.Abs(summ);
}