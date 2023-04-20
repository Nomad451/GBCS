//==============================================================\\
//                  Задача 25.                                  \\
//  Напишите цикл, который принимает на вход два числа (А и В)  \\
//  и возводит число А в натуральную степень В.                 \\
//                                                              \\
//  Пример:                                                     \\
//      3, 5 -> 243                                             \\
//      2, 4 ->  16                                             \\
//==============================================================\\

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int NumberPower(int a, int b) {
    int result = 1;
    for (int i = 0; i < b; i++) {
        result *= a;
    }

    return result;
}

Console.Write(NumberPower(numA, numB));