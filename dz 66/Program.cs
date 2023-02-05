//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = GetNumberFromUser("Введите число M:", "Ошибка ввода!");
int n = GetNumberFromUser("Введите число N:", "Ошибка ввода!");
Console.WriteLine ($"M = {m}, N = {n} -> {FindSum (m,n)}");


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

 int FindSum(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + FindSum(m + 1, n);
    }

}