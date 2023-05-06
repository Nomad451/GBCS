//==========================================================\\
//                  Задача 51.                              \\
//  Задайте двумерный массив. Найдите сумму элементов,      \\
//  находящихся на главной диагонали(с индексами (0, 0);    \\
//  (1, 1)) и т.д.                                          \\
//                                                          \\
//  Пример:                                                 \\
//      1 4 7 2                                             \\
//      5 9 2 3                                             \\
//      8 4 2 4                                             \\
//  Сумма элементов главной диагонали: 1 + 9 + 2 = 12       \\
//==========================================================\\

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++) {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++) {
        if (i == j) {
            sum += array[i, j];
        }
    }
}
Console.Write("Сумма элементов главной диагонали = " + sum);
