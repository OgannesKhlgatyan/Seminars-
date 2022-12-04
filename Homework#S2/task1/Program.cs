// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int number = 0;
bool isParsed = false;
while (isParsed == false)
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
    if (isParsed == false)
    {
        Console.WriteLine("Пожалуйста, введите трехзначное число!");
    }
}
if (number/100 < 10 && number/100 >= 1 || number/100 > -10 && number/100 <= -1)
{
    int result = (number/10) % 10;
    Console.WriteLine("Ваше число: " + number);
    Console.WriteLine("Вторая цифра : " + Math.Abs(result));
}
else 
{
    Console.WriteLine("Число не трехзначное!!!");
}