﻿//___________________________________________________________________________________________________________________________
//Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Проверка на пятизначность обязательна
//___________________________________________________________________________________________________________________________

// Console.WriteLine("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// string num5 = Convert.ToString(num);

// if (num5.Length == 5)
// {
//     if ((num5[0] == num5[4]) || (num5[1] == num5[3]))
//     {
//         Console.WriteLine("А число то, Палиндром!!!");
//     }
//     else
//     {
//         Console.WriteLine("Хорошая попытка, но нет...не Палиндром :(");
//     }
// }
// else
// {
// Console.WriteLine("нужно число из 5 цифр, пробуй еще раз!");
// }

//___________________________________________________________________________________________________________________________
//Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//___________________________________________________________________________________________________________________________

// Console.Write("Введите X координату 1 точки ");
// int x1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите Y координату 1 точки ");
// int y1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите Z координату 1 точки ");
// int z1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите X координату 2 точки ");
// int x2 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите Y координату 2 точки ");
// int y2 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите Z координату 2 точки ");
// int z2 = int.Parse(Console.ReadLine()!);

// double C = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + + Math.Pow(z2 - z1, 2));

// Console.Write($"Расстояие между точками: {C:f4}");

//___________________________________________________________________________________________________________________________
//Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//___________________________________________________________________________________________________________________________

Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}