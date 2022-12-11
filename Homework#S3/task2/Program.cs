// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// S^2 = (Ха – Xb)^2 + (Ya – Yb)^2 + (Za – Zb)^2

Console.WriteLine("Пожалуйста, введите координаты 2-х точек. Сначала координаты 1-ой точки Ax, Ay и Az");
int X1 = int.Parse(Console.ReadLine());
int Y1 = int.Parse(Console.ReadLine());
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Теперь координаты 2-ой точки Bx и By ");
int X2 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());
int Z2 = int.Parse(Console.ReadLine());

double res = LocationSearch3D(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine(res);

double LocationSearch3D(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    int calculations = ((Ax - Bx) * (Ax - Bx)) + ((Ay - By) * (Ay - By)) + ((Az - Bz) * (Az - Bz));
    double result = Math.Sqrt((double)calculations);
    return Math.Round(result, 2);
}