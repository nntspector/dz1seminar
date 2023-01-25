//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
Random rnd = new Random ();
Console.Write ("Введите количество строк (m): ");
int m = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Введите количество столбцов (n): ");
int n = Convert.ToInt32 (Console.ReadLine ());

double [,] arr = new double[m,n];
// диапазон массива
int min = 1;
int max = 10;
////////////////////////

for (int i = 0; i<m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = min +(max-min)* rnd.NextDouble ();
    }
}
Console.WriteLine ($"{m} = m, {n} = n.");
PrintArray (arr);

void PrintArray(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}