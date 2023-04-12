//  Напишите программу, которая будет принимать на вход
// два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то прогрмма выводит остаток 
// от деления
//  Например:
//      34, 5 -> не кратно, остаток 4
//      16, 4 -> кратно

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введтите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int result = numberOne % numberTwo;

if (result == 0) {
    Console.WriteLine("Число 2 кратно числу 1.");
} else {
    Console.WriteLine("Число 2 не кратно числу 1. Остаток от деления = " + result);
}
