Console.Write("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine() ?? "");

if(a == 1)
{
     Console.WriteLine("X > 0 && Y > 0");
}
else if(a == 2)
{
    Console.WriteLine("X < 0 && Y > 0");
}
else if(a == 3)
{
    Console.WriteLine("X < 0 && Y < 0");
}
else if(a == 4)
{
    Console.WriteLine("X > 0 && Y < 0");
}
else
{
     Console.WriteLine("Ошибка! четверти не существует");
}

