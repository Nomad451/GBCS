// Задача 15: 
//      Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//      и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Программа проверяет является ли день недели - выходным.");
Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

dayOfWeek(number);

void dayOfWeek(int number) {
    if (number > 0 && number <= 7) {
        if (number == 1) {
            Console.Write("Нет");
        } else if (number == 2) {
            Console.Write("Нет");
        } else if (number == 3) {
            Console.Write("Нет");
        } else if (number == 4) {
            Console.Write("Нет");
        } else if (number == 5) {
            Console.Write("Нет");
        } else if (number == 6) {
            Console.Write("Да");
        } else if (number == 7) {
            Console.Write("Да");
        }
    } else {
        Console.Write("Неподходящее число!");
    }
}

