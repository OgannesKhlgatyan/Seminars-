// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

Random random = new Random();
int randomNumber = random.Next(100, 1000);

int digit1 = randomNumber % 10;
int digit3 = randomNumber / 100;

Console.WriteLine(randomNumber);

int result = digit3 * 10 + digit1;
Console.Write(result);