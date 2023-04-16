//                  Задача 18.
//  Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой 
//  четверти (x и y).

Console.Write("Введите номер четверти: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

// if (inputNumber == 1) {
//     Console.WriteLine("1 четверть.");
//     Console.WriteLine("X>0 Y>0");
// } else if (inputNumber == 2) {
//     Console.WriteLine("2 четверть.");
//     Console.WriteLine("X<0 Y>0");
// } else if (inputNumber == 3) {
//     Console.WriteLine("3 четверть.");
//     Console.WriteLine("X<0 Y<0");
// } else if (inputNumber == 4) {
//     Console.WriteLine("4 четверть.");
//     Console.WriteLine("X>0 Y<0");
// } else {
//     Console.WriteLine("Некорректный ввод.");
// }

//  Решение с помощью конструкции switch
switch (inputNumber) {
    case 1:
        Console.WriteLine("1 четверть.");
        Console.WriteLine("X>0 Y>0");
        break;
    case 2:
        Console.WriteLine("2 четверть.");
        Console.WriteLine("X<0 Y>0");
        break;
    case 3:
        Console.WriteLine("3 четверть.");
        Console.WriteLine("X<0 Y<0");
        break;
    case 4:
        Console.WriteLine("4 четверть.");
        Console.WriteLine("X>0 Y<0");
        break;
    default:
        Console.WriteLine("Такой четверти нет.");
        break;
}