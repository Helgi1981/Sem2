﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

Console.WriteLine("Введите первое число (больше или меньше 0): ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (больше или меньше 0): ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Введённые числа находятся в координатной четверти плоскости №1");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Введённые числа находятся в координатной четверти плоскости №2");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Введённые числа находятся в координатной четверти плоскости №3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Введённые числа находятся в координатной четверти плоскости №4");
}
else if (X == 0 || Y == 0)
{
    Console.WriteLine("Ошибка ввода!");
}