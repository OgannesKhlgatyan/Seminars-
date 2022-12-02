// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет
// 20 мин
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

int nx2 = number2 * number2;
if (number1 == nx2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
    Console.WriteLine("Первое число НЕ является квадратом второго");
