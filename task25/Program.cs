Console.Clear();
Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int result = 1;

for (int i = 0; i < b; i++)
{
    result *= a;
}

Console.WriteLine(result);
