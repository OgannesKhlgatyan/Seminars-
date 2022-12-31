/*Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.*/

int number  = ReadInt("Введите число:");
DecreaseNumbers(number);

void DecreaseNumbers(int number, int tmp = 1)
{
    Console.Write($"{number}, ");
    number--;
    if(tmp > number)
    {
        return;
    }
    DecreaseNumbers(number, tmp);
}

int ReadInt(string title)  // Проверка m и n на число (что это точно int)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Введены не корректные символы");
}