//Семинар 2.
//Домашнее задание.
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

System.Console.WriteLine("Введите номер дня недели");
string number = Console.ReadLine();
int weekNumber = int.Parse(number);

if (weekNumber == 6 || weekNumber == 7)
{
    System.Console.WriteLine($"День недели № {weekNumber} - выходной");
}
else if (weekNumber < 1 || weekNumber > 7)
{
    System.Console.WriteLine("Странный день недели");
}
else
{
    System.Console.WriteLine($"День недели № {weekNumber} - будний день");
}
