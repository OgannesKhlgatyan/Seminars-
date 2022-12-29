/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

int x = ReadInt("Введите ширину массива: ");
int y = ReadInt("Введите длинну массива: ");
int z = ReadInt("Введите глубину массива: ");
int[,,] array = Create3DArrayUniqueElements(x, y, z, (1,100));
Print3DArray(array);

int[,,] Create3DArrayUniqueElements(int x, int y, int z, (int,int) range)
{
    int[,,] array = new int[x, y, z];
    Random random = new Random();
    int tmp =random.Next(range.Item1,range.Item2);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while(AvailabilityValueIn3DArray(array, tmp))
                {
                    tmp =random.Next(range.Item1,range.Item2);
                }
                array[i,j,k] = tmp;
            }
        }
    }
    return array;
}

bool AvailabilityValueIn3DArray(int[,,] array, int value)
{
    foreach (var item in array)
    {
        if (item==value)
        {
            return true;
        }
    }
    return false;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"({i},{j},{k}) {array[i, j, k]}");
            }
        }
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