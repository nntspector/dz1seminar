Console.Write("Введите номер дня недели: ");
string userInput1 = Console.ReadLine() ?? "";
int a1 = int.Parse(userInput1);

if (a1 == 6 || a1 == 7)
{
    Console.Write ($"{a1} -> выходной день ");
}
else if (a1 > 0 && a1 < 6)
{
    Console.Write ($"{a1} -> будний день");
}
