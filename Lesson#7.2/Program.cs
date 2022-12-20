// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечетные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 47 2 5 92 3 8 42 4
// Новый массив будет выглядеть вот так:
// 1 47 2
// 58129
// 8 42 4

try
{
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    int [,] newArray = Create2DArrayNew(array);
    Console.WriteLine();
    Print2DArray(newArray);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int[,] Create2DArrayNew(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0),array.GetLength(1)];

for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                newArray[i, j] = array[i, j]*array[i, j];
            }
            else {newArray[i, j] = array[i, j];}
        }
    }

    return newArray;
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