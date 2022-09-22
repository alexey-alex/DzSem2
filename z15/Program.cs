/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/
Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int number1 = (num % 100);
int number2 = (number1 / 10);
Console.WriteLine($"{number2}");

