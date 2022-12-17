Console.Write ("Введите целое число: ");
int x = int.Parse (Console.ReadLine () ?? "");
int y = x * x;
Console.Write ($"{x} -> {y}");
