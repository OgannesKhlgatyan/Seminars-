// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = int.Parse(Console.ReadLine());
string result = GetFlipsNumberAndCompare(number);
Console.WriteLine(result);


string GetFlipsNumberAndCompare(int N)
{
    if (Math.Abs(N) > 9999 && Math.Abs(N) <= 99999)
    {
        int n1 = N % 10;
        int n2 = (N /10) % 10;
        int n3 = (N/100) % 10;
        int n4 = (N/1000) % 10;
        int n5 = (N/10000) % 10;
        int newN = (n1 * 10000 + n2 * 1000 + n3 * 100 + n4 * 10 + n5);
        if (newN == N)
        {
            return "Да";
        }
        else { return "нет"; }
    }
    else { return "-1"; }
}