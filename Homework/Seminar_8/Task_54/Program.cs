//======================================================================\\
//                  Задача 54.                                          \\
//  Задайте двумерный массив. Напишите программу, которая               \\
//  упорядочит по убыванию элементы каждой строки двумерного массива.   \\
//                                                                      \\
//  Например, задан массив:                                             \\
//      1 4 7 2                                                         \\
//      5 9 2 3                                                         \\    
//      8 4 2 4                                                         \\
//                                                                      \\
//  В итоге получается вот такой массив:                                \\
//      7 4 2 1                                                         \\
//      9 5 3 2                                                         \\
//      8 4 4 2                                                         \\
//======================================================================\\

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows,columns];

void FillArray(int m, int n) {
    int i,j;
    Random rand = new Random();

    for (i = 0; i < m; i++) {
        for (j = 0; j < n; j++) {
            array[i,j] = rand.Next(1,9);
        }
    }
}

void PrintArray(int[,] array) {
    int i,j;
    for (i = 0; i < array.GetLength(0); i++) {
        for (j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(rows,columns);
Console.WriteLine("\nИсходный массив: ");
PrintArray(array);

void SortArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(1) - 1; k++) {
                if (array[i, k] < array[i, k + 1]) {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

SortArray(array);
Console.WriteLine("\nОтсортированный массив: ");
PrintArray(array);