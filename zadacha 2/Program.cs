﻿Console.Write ("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse (userInput1);

Console.Write ("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int number2 = int.Parse (userInput2);

if (number1 > number2)
{
Console.Write ($"{number1} > {number2}, max ={number1}");
}
else 
{
Console.Write ($"{number1} < {number2}, max ={number2}");
}



