//==========================================================\\
//                      Задача 65.                          \\
//  Задайте значения M и N. Напишите программу, которая     \\
//  выведет все натуральные числа в промежутке от M до N    \\
//                                                          \\
//  M = 1; N = 5 -> "1, 2, 3, 4, 5"                         \\
//  M = 4; N = 8 -> "4, 5, 6, 7, 8"                         \\
//==========================================================\\

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");

if (m < n) {
    PrintNumbers(m, n);
} else {
    PrintNumbers(n, m);
}

int ReadInt(string text) {
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());;
}

void PrintNumbers(int m, int n) {
    if (n < m) {
        return;
    }
    Console.Write(m + " ");
    PrintNumbers(m + 1, n);
}