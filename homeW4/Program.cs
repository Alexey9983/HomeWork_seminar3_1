﻿// Задача 1 (25): Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введи число А ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введи число В ");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результатом возвздения числа {A} в степень {B} будет {Result(A, B)}");

// -----метод к задаче 1-----

// int Result(int A, int B)
// {
//     if (B == 0) return 1;
    
//     int mult = A;
//     for (int i = 2; i <= B; i++)
//     {
//         mult = mult * A;  
//     }
//     return mult;
// }

//____________________________________________________________________________________________________
// Задача 2 (27): Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введи число ");
// int W = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр числа {W} будет {Sum(W)}");

//-----метод к задаче 2-----
// int Sum(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result = result + num % 10;
//     num = num / 10;
//     }
// return result;
// }

//____________________________________________________________________________________________________
// Задача 3 (29): Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int [] array = GetArray(8);
Console.WriteLine($"[{String.Join(',', array)}]");

//-----метод к задаче 3----

int[] GetArray (int X)
{
    int [] array = new int[X];
    for (int i = 0; i < X; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}