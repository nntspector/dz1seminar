Console.Write ("Введите первое число: ");
string userInput1 = Console.ReadLine ()?? "";
int a1 = int.Parse (userInput1);

Console.Write ("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int a2 = int.Parse (userInput2);

if (a1 % a2 == 0)
{
    Console.Write ($"{a1}, {a2} -> кратно");

}
else 
{
    int result = a1 % a2;
    Console.Write ($"{a1}, {a2} -> не кратно, остаток {result}");
}

