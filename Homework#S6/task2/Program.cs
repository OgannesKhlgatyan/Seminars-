// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Давайте зададим параметры первого уравнения.");

Console.Write("Введите k1 из уравнения y = ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("k1");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" * x + b1");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b1 из уравнения y = k1 * x + ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("b1");
Console.ForegroundColor = ConsoleColor.White;
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Давайте зададим параметры второго уравнения.");
Console.Write("Введите k2 из уравнения y = ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("k2");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" * x + b2");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите b2 из уравнения y = k2 * x + ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("b2");
Console.ForegroundColor = ConsoleColor.White;
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine(WriteFormula(k1, b1));

Console.Clear();
Console.WriteLine(WriteFormula(k1, b1));
Console.WriteLine(WriteFormula(k2, b2));

FindRootsEquations(k1, b1, k2, b2);

string WriteFormula(int k, int b)
{
    if (k == 1)
    {
        if (b == 0)
        {
            return "y = x";
        }
        return $"y = x + {b}";
    }
    else if (b == 0)
    {
        return $"y = {k}x + b";
    }
    else { return $"y = {k}x + {b}"; }
}


void FindRootsEquations(int k1, int b1, int k2, int b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Уравнение имеет бесконечно большое число решений");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые паралельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых: ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
    }
}