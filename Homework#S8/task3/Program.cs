/*Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/
int m = ReadInt("Введите количество строк первой матрицы: ");
int n = ReadInt("Введите количество столбцов первой матрицы: ");
int m2 = ReadInt("Введите количество строк второй матрицы: ");
int n2 = ReadInt("Введите количество столбцов второй матрицы: ");
Console.WriteLine("Первая матрица:");
int[,] array1 = CreateRandom2DArrayInt(m, n, 0, 10);
Print2DArray(array1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
int[,] array2 = CreateRandom2DArrayInt(m2, n2, 0, 10);
Print2DArray(array2);
Console.WriteLine();
Console.WriteLine("Результат умножения:");
try
{
    int[,] result = MultiplyMatrix(array1, array2);
    Print2DArray(result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))  // пример корректного умножения 3*2 х 2*4
    {
        int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    result[i, j] += array1[i, k] * array2[k, j];
                }
            } 
        }
        return result;
    }
    else throw new Exception("Нельзя преремножить такие матрицы");
}

void Print2DArray(int[,] array)  //Печатаем матрицу любой размерности
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

int[,] CreateRandom2DArrayInt(int countLine, int countColumn, int start, int end)
{
    int[,] array = new int[countLine, countColumn];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(start, end);
        }
    }

    return array;
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