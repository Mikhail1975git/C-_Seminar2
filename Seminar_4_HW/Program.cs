//Домашнее заданире к семинару 4

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// РЕШЕНИЕ ЗАДАЧИ 25

// Console.WriteLine("Введите 1 число");
// int num1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите 2 число");
// int num2 = Convert.ToInt32 (Console.ReadLine());

// double result = Math.Pow(num1, num2);

// Console.WriteLine(result);

//_____________________________________________________________________

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// РЕШЕНИЕ ЗАДАЧИ 27

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32 (Console.ReadLine());

// int GetCountNumb()
// {
//    int count=0;
//    while (num>0)
//     {
//         count=count+num%10;
//         num/=10; 
//     }
//    return count; 
// }

// Console.WriteLine(GetCountNumb());


//_____________________________________________________________________

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// РЕШЕНИЕ ЗАДАЧИ 29

// int [] GetArray()
// {
//     int [] array=new int [8];
//     for (int i = 0; i < array.Length; i++)
//     {
//       array[i]=new Random().Next(0,100); 
//     }
//     return array;
// }
// Console.WriteLine("[{0}]", String.Join(",",GetArray()));

// // или если конкретные значения:

// Console.WriteLine("Введите 1 число массива");
// int num1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите 2 число массива");
// int num2 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите 3 число массива");
// int num3 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите 4 число массива");
// int num4 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите 5 число массива");
// int num5 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите 6 число массива");
// int num6 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите 7 число массива");
// int num7 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите 8 число массива");
// int num8 = Convert.ToInt32 (Console.ReadLine());

// int [] array=new int [8];

// array[0]=num1;
// array[1]=num2;
// array[2]=num3;
// array[3]=num4;
// array[4]=num5;
// array[5]=num6;
// array[6]=num7;
// array[7]=num8;

// Console.WriteLine("[{0}]", String.Join(",", array));

//_____________________________________________________________________