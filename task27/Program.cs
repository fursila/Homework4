﻿Console.Clear();
Console.WriteLine("Ведите число");
int number = int.Parse(Console.ReadLine()!);
int sum = 0;

while (number > 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine(sum);
