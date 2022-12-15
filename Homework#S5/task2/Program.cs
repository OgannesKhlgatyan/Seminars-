// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексы).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateRandomArray(7, 0, 5);
PrintArray(array, "Random Array");

(int, int) evenAndOddPosition = CountingEvenAndOddPosition(array);
Console.WriteLine("Сумма чисел стоящих на четных позициях (индексах): " + evenAndOddPosition.Item1);
Console.WriteLine("Сумма чисел стоящих на нечетных позициях (индексах): " + evenAndOddPosition.Item2);

(int, int) CountingEvenAndOddPosition(int[] array)
{
    int evenPosition = 0;
    int oddPosition = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            evenPosition += array [i];
        }
        else
        {
            oddPosition += array [i];
        }
    }

    return (evenPosition, oddPosition);
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