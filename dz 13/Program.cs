Console.WriteLine("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";
int a1 = int.Parse(userInput1);
if (a1 < 100 && a1 > -100)
{
    Console.WriteLine($"{a1} -> третьей цифры нет");

}
else
{
    while (a1 >= 1000)
    {
        a1 /= 10;
    }
    int a2 = a1 % 10;
    Console.WriteLine($"{a2} -> третья цифра");
}

