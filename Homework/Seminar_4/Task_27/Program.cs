//======================================================\\
//                  Задача 27.                          \\
//  Напишите программу, которая принимает на вход чсло  \\
//  и выдает сумму цифр в числе.                        \\
//                                                      \\
//  Пример:                                             \\
//      452 -> 11                                       \\
//       82 -> 10                                       \\
//     9012 -> 12                                       \\
//======================================================\\

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int number) {
    int sum = 0;
    string numLength = Convert.ToString(number);
    for (int i = 0; i < numLength.Length; i++) {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

Console.Write($"Сумма цифр в числе - {num}, равно: {SumOfNumbers(num)}");