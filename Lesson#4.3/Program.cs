// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int [] array =new int[8];
FillArray (array);
PrintArray(array);

void FillArray (int [] array)
{
    Random random= new Random();
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = random.Next(0,2);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

