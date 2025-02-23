﻿//------метод к задачам------

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];  
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
//_________________________________________________________________________________________________________________________________________________________________________________
/*Задача 1 (34): Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

// int[] array = GetArray(10, 100, 999);
// Console.WriteLine($"[{String.Join(",", array)}]");
// int countEven = 0;
// int countNotEven = 0;
// foreach (int el in array)
// {
//     int N = el % 2;
//     if(N == 0)
//     {
//         countEven++;
//     }
//     else
//     {
//         countNotEven++;
//     }
// }
// Console.WriteLine($"Количество нечетных чисел в массиве -> {countNotEven}");
// Console.WriteLine($"Количество четных чисел в массиве  -> {countEven}");


/*__________________________________________________________________________________________________________________________________________________
Задача 2 (36): Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

// int[] array2 = GetArray(6, -5, 10);
// Console.WriteLine($"Наш массив [{String.Join(",", array2)}]");
// int Sum = 0;

//     for (int i = 0; i < array2.Length; i++)
//     {
//         if(i % 2 != 0)
//         {
//             Sum = Sum + array2[i];
//         }
//     }

//     Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах = {Sum}");

/*__________________________________________________________________________________________________________________________________________________
Задача 3 (37): Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] array3 = GetArray(5, 1, 10);
Console.WriteLine($"[{String.Join(",", array3)}]");

int size = array3.Length / 2;
if (array3.Length % 2 == 1) size++;
int[] result = new int[size];
for (int i = 0; i < array3.Length / 2; i++)
{
    result[i] = array3[i] * array3[array3.Length - 1 - i];
}
if(array3.Length % 2 == 1) result[size - 1] = array3[array3.Length / 2];

Console.WriteLine($"Результат задачи ->[{String.Join(",", result)}]");










