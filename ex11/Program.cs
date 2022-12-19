var rnd = new Random();
int num = rnd.Next(100, 1000);
int a1 = num / 100;
int a2 = num % 100;
int a3 = a2 % 10;

Console.WriteLine($"{num} - > {a1} {a3}");
