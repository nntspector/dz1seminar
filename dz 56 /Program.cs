// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// int[,] arr = {{3,4,5},
//                             {5,7,8},
//                             {7,4,2},
//                             {2,3,7}};



Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество Столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");


int[,] arr = GetArray(rows, columns, 0, 10);
PrintArray(arr);
Console.WriteLine();
CheckMinSum (arr);




void CheckMinSum (int [,] arr)
{
int sum = int.MaxValue;
int index = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    int temp = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        temp += arr [i, j];
    }
    if (temp < sum)
    {
        sum = temp;
        index = i;
    }
}
Console.WriteLine("Строка: " + (index+1) + " Сумма - " + sum);
Console.WriteLine();
}



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
