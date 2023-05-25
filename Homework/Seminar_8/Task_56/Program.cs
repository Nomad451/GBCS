//==================================================================\\
//                  Задача 56.                                      \\
//  Задайте прямоугольный двумерный массив. Напишите программу,     \\
//  которая будет находить строку с наименьшей суммой элементов.    \\
//                                                                  \\
//  Например, задан массив:                                         \\
//          1 4 7 2                                                 \\
//          5 9 2 3                                                 \\
//          8 4 2 4                                                 \\
//          5 2 6 7                                                 \\
//  Программа считает сумму элементов в каждой строке и             \\
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка     \\
//==================================================================\\

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

// Функция, считающая сумму элементов в строке
int SumRow(int[,] array, int i) {
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++) {
        sum += array[i,j];
    }
    return sum;
}

int minSum = 1;
int sum = SumRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++) {
    if (sum > SumRow(array, i)) {
        sum = SumRow(array, i);
        minSum = i + 1;
    }
}

Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");