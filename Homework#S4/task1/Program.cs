// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Пожалуйста, введите 1-е число:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите 2-е число:");
int B = int.Parse(Console.ReadLine());
double result = RaiseToADegree(A, B);
Console.WriteLine(result + " является результатом возведения числа A: " + A + ", в степень B: " + B);


double RaiseToADegree(int A, int B)
{
    int i = 0;
    double mnozh = 1;

    if (B < 0)
    {
        while (i > B)
        {
            mnozh = mnozh * A;
            i--;
        }
        mnozh = 1/mnozh;
        return mnozh;
    }   
    else
    {
        while (i < B)
        {
            mnozh = mnozh * A;
            i++;
        }
    }
    return mnozh;
}