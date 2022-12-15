// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] array = CreateRandomArray(6, 0, 15);
PrintArray(array, "Random Array");

(int, int, int) result = CalculationDifferenceMaxAndMin(array);
Console.WriteLine("Max number = " + result.Item1);
Console.WriteLine("Min number = " + result.Item2);
Console.WriteLine("difference Max and Min = " + result.Item3);

(int, int, int) CalculationDifferenceMaxAndMin(int[] array)
{
    int maxNumbers = array[0];
    int minNumbers = array[1];
    int differenceMaxMin = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumbers)
        {
            maxNumbers = array[i];
        }
        else if ((array[i] < minNumbers))
        {
            minNumbers = array[i];
        }
    }
    differenceMaxMin = maxNumbers - minNumbers;
    return (maxNumbers, minNumbers, differenceMaxMin);
}

int[] CreateRandomArray(int size, int minValue, int maxValue)  // метод для заполнения массива рандомными числами
{
    Random random = new Random();
    int[] array = new int[size];

    for (var i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array, string message)  //метод для печати массива
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} - [ {str} ]");
}