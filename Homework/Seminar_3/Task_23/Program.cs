//                  Задача 23.
//  Напишите программу, которая принимает на вход число (N)
//  и выдает таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Решение без Math.Pow();
// for (int i = 1; i <= number; i++) {
//     int cube = i * i * i;
//     Console.Write(cube + " ");
// }

// Решение с помощью Math.Pow()
for (int i = 1; i <= number; i++) {
    Console.Write(Math.Pow(i, 3) + " ");
}
