﻿// ЗАДАЧА №1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


// Console.WriteLine("Введи число 1: ");
// int num1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введи число 2: ");
// int num2 = int.Parse(Console.ReadLine()!);

// if (num1 == num2)
// {
//     Console.WriteLine($"числа {num1} и {num2} равны");
// }
   
// else
//     if (num1 > num2)
//     {
//         Console.WriteLine($"число {num1} больше числа {num2}");
//     }
//     else
//     {
//         Console.WriteLine($"число {num2} больше числа {num1}");
//     }


// ЗАДАЧА №2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел


// Console.WriteLine("Введи число 1: ");
// int num1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введи число 2: ");
// int num2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введи число 3: ");
// int num3 = int.Parse(Console.ReadLine()!);

// int maxNum = num1;

// if (num2 > maxNum)
//     {
//        maxNum = num2; 
//     }
//     else
//     {
//          maxNum = num1;
//     }
// if (num3 > maxNum)
//     {
//        maxNum = num3; 
//     }
     
// Console.WriteLine($"Максимальное из трех чисел: {maxNum}");


// ЗАДАЧА №3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.WriteLine("Введи число: ");
// int num = int.Parse(Console.ReadLine()!);

// int result = num % 2;

// if (result == 0)
// {
//     Console.WriteLine($"Данное число {num} - четное");
// }
// else
// {
//     Console.WriteLine($"Данное число {num} - нечетное");
// }


// ЗАДАЧА №4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введи число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = 1;

while(num1 <= num)
{
    int result = num1 % 2;
    
    if (result == 0)
    {
        Console.Write($"{num1} ");
    }
    
    num1++;
    
}

