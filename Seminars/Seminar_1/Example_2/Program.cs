// 2. Напишите программу, которая на вход принимает два числа
//    и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// а = 2, b = 10 -> нет
// а = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB) {
    Console.WriteLine("Число 1 является квадратом числа 2.");
} else {
    Console.WriteLine("Число 1 не является квадратом числа 2.");
}