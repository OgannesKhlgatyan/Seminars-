// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа, а я найду максимальное.");
int[] n = new int[3];
n[0] = int.Parse(Console.ReadLine());
n[1] = int.Parse(Console.ReadLine());
n[2] = int.Parse(Console.ReadLine());
int max = n[0];

if (max > n[1])
{}
else max = n[1];
if (max > n[2])
{}
else max = n[2];

Console.WriteLine("Максимальное число - " + max);