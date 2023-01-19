// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear ();


int[] array = new int[6];

FillArray(array);

int countPositives = GetSumPositives(array);

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.Write($" -> {countPositives}");

void FillArray(int[] collection)
{
    int lengthArray = collection.Length;
    for (int i = 0; i < lengthArray; i++)
    {
        while (true)
        {
            Console.Write($"Введите {i+1}-й элемент числового ряда: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
            if (isCorrect)
                {
                collection[i] = num;
                break;
                }
            else Console.WriteLine("Ошибка ввода!");
        }
    }
}

int GetSumPositives(int[] array)
{
    int sum = 0;

    for(int i=0; i<array.Length; i++)
    {
        if(array[i] > 0) sum ++;
    }

    return sum;
}
