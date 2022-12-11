// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Укажите размер массива:");
int[] n = new int[int.Parse(Console.ReadLine())]; // int.Parse(Console.ReadLine()) предлагаю ввести размер массива с консоли
Console.WriteLine("Заполите массив целыми числами:");
GetIncomeNumbers(n);  // Использую метод для заполнения массива
PrintArray(n); // Использую метод для вывода массива

void GetIncomeNumbers(int[] n)
{
    for (int i = 0; i < n.Length; i++)
    {
        n[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}
