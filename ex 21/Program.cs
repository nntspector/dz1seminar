﻿Console.Clear();
Console.Write("Введите x первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите x второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
double result = Math.Sqrt (Math.Pow (x2-x1,2)+ Math.Pow(y2-y1,2));
Console.Write (result);