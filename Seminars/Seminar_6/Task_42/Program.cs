﻿//======================================================\\
//                  Задача 42.                          \\
//  Напишите программу, которая будет преобразовывать   \\
//  десятичное число в двоичное.                        \\
//                                                      \\
//  Пример:                                             \\
//      45 -> 101101                                    \\
//       3 -> 11                                        \\
//       2 -> 10                                        \\
//======================================================\\

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = "";

while (num > 0) {
    result = num % 2 + result;
    num = num / 2;
}

Console.WriteLine("Двоичный вариант: " + result);