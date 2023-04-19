//                  Задача 26.                     \\
//  Напишите программу, которая принимает на вход  \\
//  число и выдает количество цифр в числе.        \\
//                                                 \\ 
//  Пример:                                        \\ 
//      456 -> 3                                   \\ 
//       78 -> 2                                   \\ 
//    89126 -> 5                                   \\ 
//=================================================\\

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// 1 способ 
int GetNumLength() {
    return Convert.ToString(number).Length;
}
Console.Write("Способ 1: " + GetNumLength());
Console.WriteLine();

// 2 способ 
int GetNumLength2() {
    int i = 0;
    while (number != 0) {
        number /= 10;
        i++; 
    }
    return i;
}
Console.Write("Способ 2: " + GetNumLength2());
