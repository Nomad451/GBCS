//==============================================================\\
//                      Задача 66.                              \\
//  Задайте значения M и N. Напишите программу, которая         \\
//  найдёт сумму натуральных элементов в промежутке от M до N.  \\
//                                                              \\
//  M = 1; N = 15 -> 120                                        \\
//  M = 4, N = 8  ->  30                                        \\
//==============================================================\\

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");

Console.Write(SumNumbers(m, n));

int SumNumbers(int m, int n) {
    if (m == n) {
        return n;
    } else {
        return m + SumNumbers(m + 1, n);
    }
}

int ReadInt(string text) {
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
