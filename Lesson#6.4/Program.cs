// Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.


int[] array = { 1, 2, 3, 4, 5 };
int[] result = CopyMassive(array);
PrintArray(result, "Скопированный массив ");
Reverse(array);
PrintArray(result, "Скопированный массив 2");
result = array;
Reverse(array);
PrintArray(result, "Скопированный массив 3");

int[] CopyMassive(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void Reverse(int[] array)
{
    int tmp;
    for (var i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}

void PrintArray(int[] array, string message)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} - [ {str} ]");
}


