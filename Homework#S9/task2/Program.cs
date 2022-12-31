/*Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.*/

int M = ReadInt("Введите число M:");
int N = ReadInt("Введите число N:");
int sum;
if (M > N) sum = Sum(N, M);
else sum = Sum(M, N);
Console.WriteLine($"Сумма чисел от {M} до {N} равна: {sum}");

int Sum(int m, int n)
{
    int result = 0;
    if (m <= n)
    {
        result += m;
        m++;
        return result + Sum(m, n);
    }
    return result;

}

int ReadInt(string title)  // Проверка m и n на число (что это точно int)
{
    Console.WriteLine(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Введены не корректные символы");
}