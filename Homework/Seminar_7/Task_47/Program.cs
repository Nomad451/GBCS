//==================================================\\
//                  Задача 47.                      \\
//  Задайте двумерный массив размером m x n,        \\
//  заполненный случайными вещественными числами.   \\
//                                                  \\
//  Пример:                                         \\
//      m = 3, n = 4                                \\
//      [0.5, 7, -2 -0.2]                           \\
//      [1, -3.3, 8, -9,9]                          \\
//      [8, 7.8, -7.1, 9]                           \\
//==================================================\\

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, columns];

for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
        array[i, j] = Math.Round(new Random().Next(-100, 101) * 0.1, 1);
        Console.Write("{0,5:F1}", array[i, j]);
    }
    Console.WriteLine();
}