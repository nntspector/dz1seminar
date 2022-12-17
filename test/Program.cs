Console.Write ("Введите новое число: ");
int x = int.Parse (Console.ReadLine () ?? "");
Console.Write ($"{x} ->");
for (int count = 0; count < x; count++)
{
if (count %2 !=0)
{
    Console.Write ($"{count}, ");
}
}
Console.WriteLine ();