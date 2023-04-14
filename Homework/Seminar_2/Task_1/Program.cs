// Задача 10: 
//      Напишите программу, которая принимает на вход трёхзначное число 
//      и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трезначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = number % 100;
int secondNumber = num / 10;

Console.WriteLine("Вторая цифра из этого числа: " + secondNumber);
