// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = CreateRandomArray(12, -10, 10);
PrintArray(array, "Random Array");

int[] newArray = AddingPairs(array);
PrintArray(newArray, "Adding Pairs Array");

int[] AddingPairs(int[] array)
{
    int[] arrayPairs = new int[array.Length / 2];
    for (var i = 0; i < array.Length/2; i++)
    {
        arrayPairs[i] = array[i] * array[array.Length - 1 - i];
    }
    return arrayPairs;
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