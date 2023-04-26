﻿//==========================================================\\
//                  Задача 40.                              \\
//  Напишите программу, которая принимает на вход три       \\
//  числа и проверяет, может ли существовать треугольник    \\
//  со сторонами такой длины.                               \\
//==========================================================\\

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if ((a < (b + c)) && (b < (a + c)) && (c < (a + b))) {
    Console.WriteLine("Такой треугольник существует.");
} else if (a <= 0 || b <= 0 || c <= 0) {
    Console.WriteLine("Некорректный ввод.");
} else {
    Console.WriteLine("Такой треугольник не существует.");
}
