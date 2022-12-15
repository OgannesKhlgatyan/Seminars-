// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = CreateRandomArray(9, 100, 999);
PrintArray(array, "Random Array");

(int, int) evenAndOddNumbers = CountingEvenAndOddNumbers(array);
Console.WriteLine("Четных чисел в массиве: " + evenAndOddNumbers.Item1);
Console.WriteLine("Нечетных чисел в массиве: " + evenAndOddNumbers.Item2);

(int, int) CountingEvenAndOddNumbers(int[] array)
{
    int evenNumbers = 0;
    int oddNumbers = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNumbers += 1;
        }
        else
        {
            oddNumbers += 1;
        }
    }

    return (evenNumbers, oddNumbers);
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