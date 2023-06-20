// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("введите цифру - обозначающею день недели");
int DayWeek = Convert.ToInt32(Console.ReadLine());

if (DayWeek == 1)
{
    System.Console.WriteLine("Нет");
}
if (DayWeek == 2)
{
    System.Console.WriteLine("Нет");
}
if (DayWeek == 3)
{
    System.Console.WriteLine("Нет");
}
if (DayWeek == 4)
{
    System.Console.WriteLine("Нет");
}
if (DayWeek == 5)
{
    System.Console.WriteLine("Нет");
}
if (DayWeek == 6)
{
    System.Console.WriteLine("Да");
}
if (DayWeek == 7)
{
    System.Console.WriteLine("Да");
}
