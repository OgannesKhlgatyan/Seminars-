// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


try
{
    Console.WriteLine("Задайте размерность массива в формате m*x");
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    double[,] array = Create2DArray(m, n);

    Console.WriteLine("Какой элемент вы i и j, чтобы получить элемент массива:");
    int iNum = ReadInt("Введите i");
    int jNum = ReadInt("Введите j");
    double result = SearchCount(array, iNum, jNum);
    Console.WriteLine(result);

    Console.WriteLine("Выведем таблицу для более простой проверки:");
    Print2DArray(array);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(double[,] array)
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

double[,] Create2DArray(int m, int n)

{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] += Math.Round(random.NextDouble() * 10, 2); 
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

double SearchCount(double[,] array, int i, int j)
{
    if (i < array.GetLength(0))
    {
        if (j < array.GetLength(1))
        {
            double count = array[i, j];
            return count;
        }
    }
    throw new Exception("Вы вышли за границы массива! Перезапустите программу и попробуйте снова!");
}
