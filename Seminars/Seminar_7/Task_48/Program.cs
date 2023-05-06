//==========================================================\\
//                  Задача 48.                              \\
//  Задайте двумерный массив размера m x n, каждый          \\
//  элемент в массиве находится по формуле: A(mn) = m + n.  \\
//  Выведите полученный массив на экран.                    \\
//                                                          \\
//  Пример:                                                 \\
//      m = 3, n = 4.                                       \\
//      0 1 2 3                                             \\
//      1 2 3 4                                             \\
//      2 3 4 5                                             \\
//==========================================================\\

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
        array[i, j] = i + j;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
