//                  Задача 19.
//  Напишите программу, которая принимает на вход пятизначноеэ
//  число и проверяет, является ли оно палиндромом.

Console.WriteLine("Программа проверяет, является ли число палиндромом.");
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = 0;
int result = 0;
int originalNum = number;               // копируем оригинальное число

while(number != 0) {
    remainder = number % 10;            // берем отаток от деления
    result = result * 10 + remainder;   // записываем в результат(для дальнейшего сравнения)
    number = number / 10;               // убираем единицы из числа
}

if (originalNum == result) {            // сравниваем оригинальное число с результатом
    Console.Write("Число является палиндромом");
} else {
    Console.Write("Число не является палиндромом");
} 


