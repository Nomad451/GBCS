﻿//==================================================================\\
//                  Задача 32.                                      \\
//  Напишите программу замена элементов массива: положительные      \\
//  элементы замените на соответствующие отрицательные, и наоборот  \\
//                                                                  \\
//  Пример:                                                         \\
//      [-4, -8, 8, 2] -> [4, 8, -8, -2]                            \\
//==================================================================\\

int[] arr = new int[4];

Console.Write("Массив до изменений: ");
for (int i = 0; i < arr.Length; i++) {
    arr[i] = new Random().Next(-5, 6);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

Console.Write("Массив после изменений: ");
for (int i = 0; i < arr.Length; i++) {
    arr[i] *= -1;   // меняем знак на противоположный
    Console.Write(arr[i] + " ");
}


