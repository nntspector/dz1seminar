// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18






int[,] firstMatrix = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] secondMatrix = new int[,] { { 3, 4 }, { 3, 3 } };

int[,] result = MultiplyMatrices(firstMatrix, secondMatrix);

Console.WriteLine("Результат умножения двух матриц составит: ");
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}
        

static int[,] MultiplyMatrices(int[,] a, int[,] b)
{
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                sum += a[i, k] * b[k, j];
            }
            result[i, j] = sum;
        }
    }


    return result;
}