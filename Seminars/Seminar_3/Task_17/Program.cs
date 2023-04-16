//                  Задача 17.
//  Напишите программу, которая принимает на вход
//  координаты (X и Y), причем X != 0 и Y != 0 и
//  выдает номер четверти плоскости,  в которой находится эта точка. 

Console.Write("Введите число X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0) {
    Console.WriteLine("1 четверть.");
} else if (X < 0 && Y > 0) {
    Console.WriteLine("2 четверть.");
} else if (X < 0 && Y < 0) {
    Console.WriteLine("3 четверть.");
} else if (X > 0 && Y < 0) {
    Console.WriteLine("4 четверть.");
} else {
    Console.WriteLine("Точка находится на одной или двух осях координат.");
}