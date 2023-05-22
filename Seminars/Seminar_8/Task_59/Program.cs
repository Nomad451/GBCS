//==============================================================\\
//                  Задача 59.                                  \\
//  Задайте двумерный массив из целых чисел. Напишите           \\
//  программу, которая удалит строку и столбец, на пересечении  \\
//  которых расположен наименьший элемент массива.              \\
//==============================================================\\

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = new int[rows, columns];
int minEl = int.MaxValue;
int minRows = 0;
int minColums = 0;

void GetArray() {
    for (int i = 0; i < result.GetLength(0); i++) {
        for (int j = 0; j < result.GetLength(1); j++) {
            result[i, j] = new Random().Next(0, 10);

            if (result[i, j] < minEl) {
                minEl = result[i, j];
                minRows = i;
                minColums = j;
            }
        }
    }
}

void PrintArray() {
    for (int i = 0; i < result.GetLength(0); i++) {
        for (int j = 0; j < result.GetLength(1); j++) {
            Console.Write(result[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeArray() {
    for (int i = 0; i < result.GetLength(0); i++) {
        if (i != minRows) {
            for (int j = 0; j < result.GetLength(1); j++) {
                if (j != minColums) {
                    Console.Write(result[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

GetArray();
PrintArray();
ChangeArray();

