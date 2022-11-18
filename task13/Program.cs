// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number >= 100)
// {
//     if (number / 10)
//     Console.WriteLine($"третья цифра заданного числа {num}");
    
// }

int randomNum = new Random().Next(100,999);
Console.WriteLine(randomNum);

string stringNum = randomNum.ToString();
Console.WriteLine($"{stringNum[2]}");