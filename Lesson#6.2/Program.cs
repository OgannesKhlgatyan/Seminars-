// Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Пожалуйста введите число");
int number = int.Parse(Console.ReadLine());
string result = ConvertToSingleNumber(number);
Console.WriteLine(result);

string ConvertToSingleNumber(int number)
{
    string result = String.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}