//==========================================================\\
//                  Задача 30.                              \\
//  Напишите программу, которая выводит массив из 8         \\
//  элементов, заполненный нулями и единицами в случайном   \\
//  порядке.                                                \\
//                                                          \\
//  Пример:                                                 \\
//      [1, 0, 1, 1, 0, 1, 0, 0]                            \\
//==========================================================\\

Console.Write("Укажите размер массива: ");
int arrLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrLength];

// Заполняем массив рандомными числами от 0 до 1
int[] RandomArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(0, 2);
    }

    return arr;
}

// Печатаем массив
void PrintArray(int[] arr) {
    Console.Write("Заполненный массив: ");
    Console.Write("[" + String.Join(", ", arr) + "]");
}

RandomArray(array);
Console.WriteLine();
PrintArray(array);

