﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32 (Console.ReadLine());

int result = num/10%10;

Console.WriteLine(result);

// ________________________________________________________________________________
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Решение

// Console.WriteLine("Введите число от 1 до 100000");
// int num = Convert.ToInt32 (Console.ReadLine());
// int result = num/100%10;

// if (num<100)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else
// {
//     Console.WriteLine(result);
// }


// ________________________________________________________________________________

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Решение

// Console.WriteLine("Введите цифрой день недели");
// int num = Convert.ToInt32 (Console.ReadLine());

// if ((num==6)||(num==7))
// {
//     Console.WriteLine("да, это выходной");
// }
// else
// {
//     Console.WriteLine("нет, это не выходной");
// }


// ________________________________________________________________________________