// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Пожалуйста введите 3 числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
bool result = CheckingTheAbilityToCreateATriangle(a, b, c);
Console.WriteLine(result);


bool CheckingTheAbilityToCreateATriangle(int a, int b, int c)
{
    if (a < b + c && a + b > c && b < a + c)
    {
        return true;
    }
    else return false;
}
