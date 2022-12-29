// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int m;
int n;
try
{
    while (true)
    {
        Console.WriteLine("Задайте размерность массива в формате m*x");
        m = ReadInt("Введите m");
        n = ReadInt("Введите n");
        if (m == n)
        {
            break;
        }
    
        Console.WriteLine ("Введены не одинаковые числа. m != n");
    }

    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    Console.WriteLine("Наш перевернутый массив:");
    int[,] result = ReversArray(array);
    Print2DArray(result);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);  // если не выполняется код выше, то выполняем исключение throw new Exception("Введены не корректные символы");
}

int[,] ReversArray(int[,] array)
{
    int[,] reverseArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            reverseArray[j, i] = array[i, j];
        }
    }
    return reverseArray;
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