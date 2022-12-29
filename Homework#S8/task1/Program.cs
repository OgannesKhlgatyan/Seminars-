// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

try
{
    Console.WriteLine("Задайте размерность массива в формате m*x");
    int m = ReadInt("Введите m");
    int n = ReadInt("Введите n");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    Console.WriteLine("");
    AscendingRows (array);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);  // если не выполняется код выше, то выполняем исключение throw new Exception("Введены не корректные символы");
}

void AscendingRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] sortArray = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sortArray[j] = array[i, j];
        }
        Array.Sort(sortArray);
        Array.Reverse(sortArray);
        Console.WriteLine($"{String.Join(" ", sortArray)}");
    }

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

int[,] Create2DArray(int m, int n)  //создаем матрицу размерности m*n

{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] += random.Next(1, 10);
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