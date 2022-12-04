// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число: ");
int number = 0;
bool isParsed = false;
while (isParsed == false)
{
    isParsed = int.TryParse(Console.ReadLine(), out number);
    if (isParsed == false)
    {
        Console.WriteLine("Пожалуйста, введите цифру!");
    }
}

if (number < 100 && number > -100)
{
    Console.WriteLine("Третьей цифры нет =(");
}
else
{
    while (number > 1000 || number <= -1000)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine("Третье число: " + Math.Abs(result) + "! Вы задали очень хорошее число. Какой же вы молодчинка. В морозилке есть мороженка, угощайтесь =)");
}


// int lengthNumber = number.ToString().Length; // обратлся к методу, переводящему целое число (в данном случае) в текст, чтобы посчитать число символов. 
// if (lengthNumber >= 3)