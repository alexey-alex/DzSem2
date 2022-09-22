/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
int day = new Random().Next(1, 8);
Console.WriteLine($"День номер {day}");
if (day==7 || day == 6) Console.WriteLine("Да");
else Console.WriteLine("Нет");

