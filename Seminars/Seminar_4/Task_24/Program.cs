//==================================================\\
//                  Задача 24.                      \\
//  Напишите программу, которая принимает на вход   \\
//  число (А) и выдает сумму чисел от 1 до А.       \\
//                                                  \\
//  Пример:                                         \\
//      7 -> 28                                     \\
//      4 -> 10                                     \\
//      8 -> 36                                     \\
//==================================================\\

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int GetSumNum() {
    int sum = 0;
    int count = 0;
    while (number > count) {
        count++;
        sum += count;
    }

    return sum;
}
Console.Write(GetSumNum());
