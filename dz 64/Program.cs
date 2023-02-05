﻿
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");
Console.WriteLine("Natural numbers from 1 to " + n + ": ");
DisplayNumbers(n);







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

void DisplayNumbers(int n)
{
    if (n == 0)
    {
        return;
    }
    Console.Write(n + " ");
    DisplayNumbers(n - 1);
}
