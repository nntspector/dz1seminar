// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Clear ();
double b1 = GetNumberFromUser ("Введите значение b1: ", "Ошибка ввода");
double b2 = GetNumberFromUser ("Введите значение b2: ", "Ошибка ввода");
double k1 = GetNumberFromUser ("Введите значение k1: ", "Ошибка ввода");
double k2 = GetNumberFromUser ("Введите значение k2: ", "Ошибка ввода");
double a1 = (b1 -b2)/ (k2-k1);
double a2 = (k2 * a1) + b2;

Console.WriteLine ($" b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} ->  ({a1}; {a2})");

double GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


