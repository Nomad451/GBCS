﻿//                  Задача 22.
//  Напишите программу, которая принимает на вход число (N)
//  и выдает таблицу квадратов чисесл от 1 до N.
//
//  Пример:
//      5 -> 1, 4, 9, 16, 25.
//      2 -> 1, 4.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++) {
    Console.Write(Math.Pow(i, 2) + " ");
}