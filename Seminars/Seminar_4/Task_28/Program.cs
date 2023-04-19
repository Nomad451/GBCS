//=================================================\\
//                  Задача 28.                     \\ 
//  Напишите программу, которая принимает на вход  \\
//  число N и выдает произведение чисел от 1 до N. \\
//                                                 \\ 
//  Пример:                                        \\ 
//      4 -> 24                                    \\ 
//      5 -> 120                                   \\ 
//=================================================\\

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multiple() {
    int factorial = 1;
    for (int i = 1; i <= number; i++) {
        factorial *= i;
    }

    return factorial;
}
Console.Write(Multiple());

