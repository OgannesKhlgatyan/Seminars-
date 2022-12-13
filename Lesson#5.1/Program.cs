// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] array = CreateRandomArray(4, -9, 9);
PrintArray(array, "Random Array");
int [] newArray = ChangingTheSignItem(array);
PrintArray(newArray, "Changed Array");
// 1 вариант с переписыванием существующего массива
// void ChangingTheSignItem(int[] array)
// {
//     for (var i = 0; i < array.Length; i++)
//     {
//         array [i] = array [i] *(-1);
//     }
// }

int[] ChangingTheSignItem(int[] array)
{
    int[] newArray = new int[array.Length];
    for (var i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i] * (-1);
    }
    return newArray;
}



int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[size];

    for (var i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}

void PrintArray(int[] array, string message)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} - [ {str} ]");
}