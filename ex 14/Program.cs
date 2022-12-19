Console.Write ("Введите первое число: ");
string userInput1 = Console.ReadLine ()?? "";
int a1 = int.Parse (userInput1);

if (a1 % 7 ==0 && a1 % 23 == 0)
{

Console.Write ($"{a1} -> да");
}
else 
{
    Console.Write ($"{a1} -> нет");
}


