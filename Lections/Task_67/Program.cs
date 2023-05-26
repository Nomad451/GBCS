//======================================================\\
//                      Задача 67.                      \\
//  Напишите программу, которая будет принимать на вход \\
//  число и возвращать сумму его цифр.                  \\
//                                                      \\
//  453 -> 12                                           \\
//   45 -> 9                                            \\
//======================================================\\

int n = ReadInt("Введите число: ");
if (n < 0) {
    System.Console.WriteLine("Не корректное число.");
    return;
}

System.Console.WriteLine(SumNumbers(n));

int ReadInt(string text) {
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int n) {
    if (n < 1) {
        return 0;
    }
    return n % 10 + SumNumbers(n / 10);
}