// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
//
// Например:
//     78 -> 8
//     12 -> 2
//     85 -> 8

int num = new Random().Next(10, 100);
Console.WriteLine(num);

int a = num / 10;   // сюда складываем десятки
int b = num % 10;   // сюда - остаток от деления

if (a > b) {
    Console.Write(a);
} else if (a < b) {
    Console.Write(b);
} else {
    Console.Write("Числа равны.");
}

