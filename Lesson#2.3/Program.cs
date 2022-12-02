// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число, а я проверю кратно ли оно 7 и 23 одновременно");
int number = int.Parse(Console.ReadLine());

double num = (double)number;

if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write("Число одновременно кратно 7 и 23");
}
else 
Console.Write("Число " + number + " НЕ кратно 7 и 23 одновременно");