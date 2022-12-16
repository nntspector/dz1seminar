Console.Write ("Введите число: ");
string userInput1 = Console.ReadLine ()?? "";
int number1 = int.Parse (userInput1);
int number2 = number1 % 2;
if (number2 == 0)
{
Console.Write ($"{number1} -> четное");
}
else
{
Console.Write ($"{number1} -> нечетное");
}