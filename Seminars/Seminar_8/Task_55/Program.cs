//==================================================\\
//                  Задача 55.                      \\
//  Задайте двумерный массив. Напишите программу,   \\
//  которая заменяет строки на столбцы. В случае,   \\
//  если это невозможно, программа должна вывести   \\
//  сообщение для пользователя.                     \\
//==================================================\\

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = new int[rows, columns];
int[,] result2 = new int[rows, columns];

void GetArray() {
    for (int i = 0; i < result.GetLength(0); i++) {
        for (int j = 0; j < result.GetLength(1); j++) {
            result[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeArray() {
    for (int i = 0; i < result.GetLength(0); i++) {
        for (int j = 0; j < result.GetLength(1); j++) {
            result2[j, i] = result[i, j];
        }
    }
}

GetArray();
PrintArray(result);
ChangeArray();
PrintArray(result2);