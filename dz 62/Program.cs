// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] spiralArray = new int[4, 4];

int value = 1;
int minRow = 0;
int maxRow = 3;
int minCol = 0;
int maxCol = 3;

while (value <= 16)
{
    for (int i = minCol; i <= maxCol; i++)
    {
        spiralArray[minRow, i] = value;
        value++;
    }

    for (int i = minRow + 1; i <= maxRow; i++)
    {
        spiralArray[i, maxCol] = value;
        value++;
    }

    for (int i = maxCol - 1; i >= minCol; i--)
    {
        spiralArray[maxRow, i] = value;
        value++;
    }

    for (int i = maxRow - 1; i >= minRow + 1; i--)
    {
        spiralArray[i, minCol] = value;
        value++;
    }

    minRow++;
    minCol++;
    maxRow--;
    maxCol--;
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(spiralArray[i, j] + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();
