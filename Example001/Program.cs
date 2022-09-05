// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
int num = new Random().Next(100, 1000);

Console.WriteLine(num);

int n2 = ((num % 100) / 10);
Console.WriteLine(n2);
