//Напишите программу, которая заполнит спирально массив 4 на 4.

int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");
int[,] array = new int[m, n];
FillSpiral(array);
Print2DArray(array);
 
void FillSpiral(int[,] array)
{
    int startX = 0, finishX = array.GetLength(0) - 1,
        startY = 0, finisY = array.GetLength(1) - 1;
    int currentX = 0, currentY = 0;
    int number = 1;

    while (number < array.Length)
    {
        currentX = startX;
        for (currentY = startY; currentY < finisY; currentY++)
        {
            array[currentX, currentY] = number;
            number++;
        }
        finisY--;
        for (currentX = startX; currentX < finishX; currentX++)
        {
            array[currentX, currentY] = number;
            number++;
        }
        finishX--;
        for (currentY = finisY + 1; currentY > startY; currentY--)
        {
            array[currentX, currentY] = number;
            number++;
        }
        startY++;
        for (currentX = finishX + 1; currentX > startX; currentX--)
        {
            array[currentX, currentY] = number;
            number++;
        }
        startX++;
    }



}


void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 == 0) Console.Write("0" + array[i, j] + " ");
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
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