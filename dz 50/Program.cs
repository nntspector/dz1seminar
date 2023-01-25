// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и возвращает значение
// этого элемента или же указание, что такого элемента нет
Console.Clear();
Console.Write ("Введите количество строк массива: ");
int rows = int.Parse (Console.ReadLine () ?? "");

Console.Write ("Введите количество элементов массива: ");
int columns = int.Parse (Console.ReadLine ()?? "");

Console.Write ("Введите индекс строки  элемента: ");
int position1 = int.Parse (Console.ReadLine () ?? "");

Console.Write ("Введите индекс столбца  элемента: ");
int position2 = int.Parse (Console.ReadLine () ?? "");

int [,] arr = GetArray (rows, columns, 0, 10);

PrintArray (arr);
CheckElement (position1, position2);


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

void CheckElement (int col, int row)
{
if ((col >= 0 && col < arr.GetLength (0)) && (row >=0 && row<arr.GetLength (1)))
{
   Console.Write (arr [col,row]);
}
else
{
Console.Write ("Такого элемента нет");
}
}
