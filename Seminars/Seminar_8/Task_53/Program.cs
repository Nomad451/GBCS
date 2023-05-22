//==========================================================\\
//                  Задача 53.                              \\
//  Задайте двумерный массив. Напишите программу, которая   \\
//  поменяет местами первую и последнюю строку массива.     \\
//==========================================================\\

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = new int[rows, columns];

void GetArray() {
    for (int i = 0; i < result.GetLength(0); i++) {
        for (int j = 0; j < result.GetLength(1); j++) {
            result[i, j] = new Random().Next(0, 10);
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

void ChangeRows() {
    for (int j = 0; j < result.GetLength(1); j++) {
        int temp = result[0, j];
        result[0, j] = result[result.GetLength(0) - 1, j];
        result[result.GetLength(0) - 1, j] = temp;
    }
}

GetArray();
PrintArray();
ChangeRows();
PrintArray();