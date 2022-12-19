var rnd = new Random();
int num = rnd.Next(100, 1000);
int a1 = num / 10;
int a2 = a1 % 10;
Console.WriteLine($"{num} - > {a2}");
