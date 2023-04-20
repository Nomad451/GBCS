//===========================================================\\
//                  Задача 29.                               \\
//  Напишите программу, которая задает массив из 8 элементов \\
//  и выводит их на экран.                                   \\
//                                                           \\
//  Пример:                                                  \\
//      1, 2, 5, 7, 19, 6, 1, 33 ->                          \\
//     [1, 2, 5, 7, 19, 6, 1, 33]                            \\
//===========================================================\\

Console.Write("Укажите длину массива: ");
int arrLength = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[arrLength];

Console.WriteLine("Заполните и распечатайте массив: ");
PrintArray(arr, arrLength);


void PrintArray(int[] array, int arrayLength) {
    for (int i = 0; i < arrayLength; i++) {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("[" + String.Join(", ", array) + "]");
}