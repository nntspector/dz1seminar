Console.Write ("Введите первое число: ");
string userInput1 = Console.ReadLine ()?? "";
int number1 = int.Parse (userInput1);

Console.Write ("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int number2 = int.Parse (userInput2);

Console.Write ("Введите третье число: ");
string userInput3 = Console.ReadLine() ?? "";
int number3 = int.Parse (userInput3);


if (number1 > number2)
{
    Console.Write ($"{number1}, {number2}, {number3} -> {number1}");
}
else if (number3>number1)
{
Console.Write ($"{number1}, {number2}, {number3} -> {number3}");
}
else if  (number2 > number1)
{
Console.Write ($"{number1}, {number2}, {number3} -> {number2}");
}
else if  (number2 < number3)
{
Console.Write ($"{number1}, {number2}, {number3} -> {number3}");
}
