// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

int num = int.Parse(Console.ReadLine());
int result = CheckCountNumber(num);
Console.WriteLine(result);


int CheckCountNumber(int number)
{
    int count = 0;
    for (int i = 1; number > 0; i++)
    {
        number = number / 10;
        count = count + 1;
    }
    return count;
}