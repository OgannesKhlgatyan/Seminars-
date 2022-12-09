// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чиселот 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

int num = int.Parse(Console.ReadLine());
int[] arr = GetCalculateTheSquaresOfnumbers(num);

PrintArray(arr);

int[] GetCalculateTheSquaresOfnumbers(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = (i+1) * (i+1);
    }
    return array;
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

