// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = GetArray(8, 100, 1000);
Console.Write("[");
Console.Write(String.Join(" ",  array ));
Console.Write("]");
int count = GetChetCount(array);
Console.Write($" -> {count}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
int GetChetCount(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count ++;
    }
    return count;
}








