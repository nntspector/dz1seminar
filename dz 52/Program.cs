//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.Write ("Введите количество строк массива: ");
int rows = int.Parse (Console.ReadLine () ?? "");

Console.Write ("Введите количество столбцов массива: ");
int columns = int.Parse (Console.ReadLine ()?? "");

int [,] arr = GetArray (rows, columns, 0, 10);

PrintArray (arr);
AverageSumColumns (arr);



int [,] GetArray (int m, int n, int minValue, int maxValue)
{
int [,] result = new int [m,n];
for (int i = 0; i < m; i++)
{
   for (int j =0; j < n; j++)
   {
       result [i,j] = new Random().Next (minValue, maxValue+1);
   }
}
   return result;
}

void PrintArray (int [,] arr)
{
for (int i = 0; i <arr.GetLength (0); i++)
{
   for (int j =0; j < arr.GetLength(1); j++)
   {
       Console.Write ($"{arr[i, j]} ");
   }
   Console.WriteLine ();
}
}

void AverageSumColumns(int[,] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        double result = Math.Round(sum / arr.GetLength(0), 1);
        if (j == arr.GetLength(1) - 1) Console.Write($"{result}. ");
        else Console.Write($"{result}; ");
    }
}