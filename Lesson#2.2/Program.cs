// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

double num1 = (double)number1;
double num2 = (double)number2;
double ost = (num2 % num1);
if (ost == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else 
 Console.WriteLine("Число имеет остаток: " + ost);