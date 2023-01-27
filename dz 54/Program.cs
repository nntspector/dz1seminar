// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество Столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");


int[,] arr = GetArray(rows, columns, 0, 10);
PrintArray(arr);
GetMaxMin(arr);
Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            if (arr[i, j] <= arr[i, k]) continue;
            int temp = arr[i, j];
            arr[i, j] = arr[i, k];
            arr[i, k] = temp;
        }

PrintArray(arr);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetMaxMin(int[,] arr)
{
    int max = arr[0, 0];
    int min = arr[0, 0];
    int maxI = 0;
    int maxJ = 0;
    int minI = 0;
    int minJ = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (max < arr[i, j])
            {
                max = arr[i, j];
                maxI = i;
                maxJ = j;
            }
            if (min > arr[i, j])
            {
                min = arr[i, j];
                minI = i;
                minJ = j;
            }
        }
}
