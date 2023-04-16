//                  Задача 21.
//  Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 2D пространстве.
//  
//  Пример:
//      А(3, 6); B(2, 1)   -> 5,09
//      A(7, -5); B(1, -1) -> 7,21

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); 
d = Math.Round(d, 2); // округляем число - 2 знака после запятой
Console.Write(d);