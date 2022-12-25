// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    ArithmeticMeanByColumns(array);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


void ArithmeticMeanByColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double[] quantityJ = new double[array.GetLength(0)]; // собираем инфу по колличеству j, чтобы в методе Average посчитать среднее арифм.
        for (int j = 0; j < array.GetLength(0); j++)
        {
            quantityJ[j] = array[j, i];
        }
        Console.Write($"{Average(quantityJ)}, ");
    }
}


void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];


    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }

    return array;
}

int ReadInt(string title)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Введены не корректные символы");
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

double Average(double[] array)
{
    double arraySum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        arraySum += array[i];
    }
    return Math.Round((arraySum / array.Length), 2);
}