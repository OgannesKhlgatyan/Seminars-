// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int number = int.Parse(Console.ReadLine());
double[] array = ReturnFirstNumbersFebonachi(number);
PrintArray(array, $"Первые {number} чисел Фебоначи.");


double[] ReturnFirstNumbersFebonachi(int number)
{
    int i = 0;
    double[] resArray = new double[number];

    if (number < 1)
    {
        return resArray;
    }
    resArray[0] = 0;
    if (number < 2)
    {
        return resArray;
    }
    resArray[1] = 1;
    for (i = 2; i < number; i++)
    {
        resArray[i] = resArray[i - 1] + resArray[i - 2];
    }
    return resArray;
}



void PrintArray(double[] array, string message)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} - [ {str} ]");
}