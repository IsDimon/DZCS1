﻿Console.Clear();
Console.Write("Введите координату X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату Z2: ");
double z2 = double.Parse(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(z2-z1,2)+Math.Pow(y2-y1,2));
Console.WriteLine($"d={d:f2}");



