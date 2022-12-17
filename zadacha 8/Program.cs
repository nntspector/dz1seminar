Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write($"{a} -> ");
for (int count = 0; count < a; count++)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
    }
}
Console.WriteLine();
