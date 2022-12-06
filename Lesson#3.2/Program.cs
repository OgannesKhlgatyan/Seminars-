// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21
// d = √ (х А – х В) 2 + (у А – у В) 2

Console.WriteLine("Пожалуйста, введите координаты 2-х точек. Сначала координаты 1-ой точки Ax и Ay ");
int X1 = int.Parse(Console.ReadLine());
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Теперь координаты 2-ой точки Bx и By ");
int X2 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());

double res = GetСalculateTheDistanceBetweenPoints(X1, Y1, X2, Y2);

Console.WriteLine(res);

double GetСalculateTheDistanceBetweenPoints(int Ax, int Ay, int Bx, int By)
{
    int calculations = (Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By);
    double result = Math.Sqrt((double)calculations);
    return Math.Round(result, 2);
}