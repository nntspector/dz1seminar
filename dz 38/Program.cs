// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int[] array = GetArray(8, 100, 1000);
Console.Write("[");
Console.Write(String.Join(" ", array));
Console.Write("]");
int max = Max(array);
int min = Min(array);
Console.Write($" -> {max - min}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
int Max(int[] arr)
{

    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] > max)
            max = arr[i];

    }
    return max;
}
int Min(int[] arr)
{

    int min = arr [0];
    for (int i = 0; i < arr.Length; i++)
    {

            if (min > arr [i])
            {
               min = arr [i];
            }
    }
    return min;
}


