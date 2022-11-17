// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели числом: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 == 1)
Console.WriteLine("Понедельник, не является выходным");

if (number1 == 2)
Console.WriteLine("Вторник, не является выходным");

if (number1 == 3)
Console.WriteLine("Среда, не является выходным");

if (number1 == 4)
Console.WriteLine("Четверг, не является выходным");

if (number1 == 5)
Console.WriteLine("Пятница, не является выходным");

if (number1 == 6)
Console.WriteLine("Суббота, выходной день!!");

if (number1 == 7)
Console.WriteLine("Воскресенье, выходной день!!");

