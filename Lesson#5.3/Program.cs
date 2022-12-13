// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = CreateRandomArray(123, -100, 100);
PrintArray(array, "Random Array");

int count = FindCount(array);
Console.WriteLine(count);



int FindCount(int[] array)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] <= 99 && array[i] >= 10)
        {
            count = count + 1;
        }
    }
    return count;
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