// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, чтобы узнать выходной этоn день или нет");
Console.WriteLine("Внимание! Число должно быть в интервале от 1 до 7");
int num = int.Parse(Console.ReadLine());


// 1-й вариант

if (num > 0 && num <= 7)
{
    if (num > 5)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Как я уже предупреждал, число должно быть в интервале от 1 до 7. Попробуйте еще раз.");
}



// 2-й вариант

// if (num == 1)
// {
//     Console.WriteLine("нет, не выходной");
// }
// else if (num == 2)
// {
//     Console.WriteLine("нет, не выходной");
// }
// else if (num == 3)
// {
//     Console.WriteLine("нет, не выходной");
// }
// else if (num == 4)
// {
//     Console.WriteLine("нет, не выходной");
// }
// else if (num == 5)
// {
//     Console.WriteLine("нет, не выходной");
// }
// else if (num == 6)
// {
//     Console.WriteLine("да, выходной");
// }
// else if (num == 7)
// {
//     Console.WriteLine("да, выходной");
// }
// else
// {
//     Console.WriteLine("Как я уже предупреждал, число должно быть в интервале от 1 до 7. Попробуйте еще раз.");
// }