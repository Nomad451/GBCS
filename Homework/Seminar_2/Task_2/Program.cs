// Задача 2: 
//      Напишите программу, которая выводит третью цифру 
//      заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

thirdNum(number);

void printThirdNum(int number) {
    if (number < 100) {
        Console.Write("Третьей цифры нет.");
    } else if (number >= 100 && number < 1000) {
        number = number % 10;
        Console.Write(number);
    } else if (number >= 1000 && number < 10000) {
        number = number % 100;
        int num = number / 10;
        Console.Write(num);
    } else if (number >= 10000 && number < 100000) {
        number = number % 1000;
        int num = number / 100;
        Console.Write(num);
    } else {
        Console.Write("Число слишком большое!");
    }
}



