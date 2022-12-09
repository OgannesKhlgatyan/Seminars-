//Задача 24: Напишите программу, которая принимает на вход число (А) 
//и выдаёт произведение чисел от 1 до А.

int a = int.Parse(Console.ReadLine());
double comp = GetСompositionNumbersBetweenOneToNumber(a);
Console.WriteLine(comp);

double GetСompositionNumbersBetweenOneToNumber(int a)
{
    int comp = 1;
    for (var i = 1; i <= a; i++)
    {
        comp = comp * i;
    }

    return comp;
}
