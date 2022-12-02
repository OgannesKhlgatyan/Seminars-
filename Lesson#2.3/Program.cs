// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число, а я проверю кратно ли оно 7 и 23 одновременно");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.Write("Число одновременно кратно 7 и 23");
}
else 
Console.Write("Число " + number + " НЕ кратно 7 и 23 одновременно");

// bool isParsed = false;
// int number = 0;
// while (isParsed == false)
// {
//     isParsed = int.TryParse(Console.ReadLine(), out number);
//     if(isParsed == false)
//     {
//         Console.WriteLine("Пиши числа!");
//     }
// }
