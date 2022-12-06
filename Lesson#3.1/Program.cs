// Задача No18. Общее обсуждение
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int quarter = int.Parse(Console.ReadLine());
string result = GetRangeByNumberOfQuarter(quarter);
Console.WriteLine(result);

string GetRangeByNumberOfQuarter(int numberOfQuarter)
{
    if (numberOfQuarter == 1)
    {
        return "(x > 0 && y > 0)";
    }

    else if (numberOfQuarter == 2)
    {
        return "(x < 0 && y > 0)";
    }

    else if (numberOfQuarter == 3)
    {
        return "(x < 0 && y < 0)";
    }

    else if (numberOfQuarter == 4)
    {
        return "(x > 0 && y < 0)";
    }

    return "-1";
}