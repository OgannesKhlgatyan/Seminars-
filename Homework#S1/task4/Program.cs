// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
if (N > 0)
{
    for (int num = 2; num < N; num += 2) 
    {
        Console.WriteLine(num);
    }
}
else
for (int num = -2; num > N; num -= 2)
    {
        Console.WriteLine(num);
    }