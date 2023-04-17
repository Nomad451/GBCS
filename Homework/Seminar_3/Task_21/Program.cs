﻿//                  Задача 21.
//  Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 3D пространстве.

// Х координаты
Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

// Y координаты
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

// Z координаты
Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

// Формула нахождения расстояния
double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + 
                            Math.Pow((y2 - y1), 2) + 
                            Math.Pow((z2 - z1), 2)); 

distance = Math.Round(distance, 2); // округляем число - 2 знака после запятой
Console.Write(distance);
