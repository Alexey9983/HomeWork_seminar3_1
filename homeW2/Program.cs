﻿//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков
//___________________________________________________________________________________________________________________________

// Console.Write("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine()!);
// int a = 0;
// if ((number<=99) || (number>=1000))

// {
//     Console.Write("Введите всетаки трехзначное число! ");
//     return;
// }   
//  else 
//  a = (number % 100)/10;
 
// Console.Write($"вторая цифра числа {number} это {a}");

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000
//___________________________________________________________________________________________________________________________

// Console.Write("Введите число от 100 до 100к: ");
// int num = int.Parse(Console.ReadLine()!);

// if ((num < 100) || (num > 100000))
// {
//     Console.Write("третьего числа нет или введено слишком большое число!");
// }   
// if ((num >= 100) && (num <= 999))
// {
//     int num3 = num % 10;
//     Console.Write($"третья цифра числа {num} это {num3}");
// }
// if ((num >= 1000) && (num <= 9999))
// {
//     int num3 = (num % 100) / 10;
//     Console.Write($"третья цифра числа {num} это {num3}");
// }
// if ((num >= 10000) && (num <= 99999))
// {
//     int num3 = (num % 1000) / 100;
//     Console.Write($"третья цифра числа {num} это {num3}");
//}

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7
//___________________________________________________________________________________________________________________________

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if ((num > 7) || (num < 1))
{
    Console.WriteLine("Нет такого дня недели");
    return;
}
if (num > 5)
{
    Console.WriteLine("Поздравляю, выходной день!");
}
else
    Console.WriteLine("Не менее веселый будний день!");