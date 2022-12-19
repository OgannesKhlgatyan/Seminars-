// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.ForegroundColor = ConsoleColor.Green; // Цвет
Console.WriteLine("Укажите размер массива:");

Console.ForegroundColor = ConsoleColor.White;  // Цвет
int[] arr = new int[int.Parse(Console.ReadLine())]; // int.Parse(Console.ReadLine()) предлагаю ввести размер массива с консоли

Console.ForegroundColor = ConsoleColor.Green;  // Цвет
Console.WriteLine("Заполите массив целыми числами:");
GetIncomeNumbers(arr);  // Использую метод для заполнения массива

PrintArray(arr, "Введенная вами матрица ");
int count = FindCountGreaterZero(arr);
Console.ForegroundColor = ConsoleColor.Green;  // Цвет
Console.Write("Число чисел больше нуля в матрице = ");
Console.ForegroundColor = ConsoleColor.White;  // Цвет
Console.Write(count);


// Метод для заполнения массива
void GetIncomeNumbers(int[] array)
{
    Console.ForegroundColor = ConsoleColor.White;  // Цвет
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
}


//Метод для подсчета чисел > 0
int FindCountGreaterZero(int[] array)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}


//метод для печати массива
void PrintArray(int[] array, string message)
{
    Console.ForegroundColor = ConsoleColor.Green;  // Цвет
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} - [ {str} ]");
}