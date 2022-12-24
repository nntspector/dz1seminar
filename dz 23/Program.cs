Console.Write ("Введите число: ");
string userInput1 = Console.ReadLine ()?? "";
int N = int.Parse (userInput1);
int count = 1;
Console.Write ($"{N} -> ");
while (N >= count)
{
    Console.Write ($"{Math.Pow(count,3)}, ");
    count++;
}
