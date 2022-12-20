// Задача из семинара3
//Не понял, как можно сделать с методом for, при int result=1, только при int result=2

//Решение

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32 (Console.ReadLine());
// Console.Write(1);
// for(int result=2;result<=num;result++)
// {
//         Console.Write(","+ result*result);
// }

//____________________________________________
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Решение

// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32 (Console.ReadLine());

// int num1=num/10000;
// int num2=num/1000%10;
// int num3=num/10%10;
// int num4=num%10;

// if (num1==num4&&num2==num3)
// {
//     Console.WriteLine("Это число палиндром");
// }
// else
// {
//     Console.WriteLine("Это число не палиндром");
// }

//или (правда, с системной руганью)

// Console.WriteLine("Введите пятизначное число");
// string num = Convert.ToString (Console.ReadLine());
// // // Console.WriteLine(num[0]); для проверки
// // // Console.WriteLine(num[1]);для проверки
// // // Console.WriteLine(num[3]);для проверки
// // // Console.WriteLine(num[4]);для проверки

// char num1 = num[0];
// int nu1=Convert.ToInt32(new string(num1, 1));
// char num2 = num[1];
// int nu2=Convert.ToInt32(new string(num2, 1));
// char num3 = num[3];
// int nu3=Convert.ToInt32(new string(num3, 1));
// char num4 = num[4];
// int nu4=Convert.ToInt32(new string(num4, 1));

// // // Console.WriteLine(nu1);для проверки
// // // Console.WriteLine(nu2);для проверки
// // // Console.WriteLine(nu3);для проверки
// // // Console.WriteLine(nu4);для проверки

// if (nu1==nu4&&nu2==nu3)
// {
//     Console.WriteLine("Это число палиндром");
// }
// else
// {
//     Console.WriteLine("Это число не палиндром");
// }
//______________________________________________________________________
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Решение

// Console.WriteLine("Введите координату x для точки 1");
// int x1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите координату y для точки 1");
// int y1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите координату z для точки 1");
// int z1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите координату x для точки 2");
// int x2 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите координату y для точки 2");
// int y2 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите координату z для точки 2");
// int z2 = Convert.ToInt32 (Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));

// Console.WriteLine(d);

//__________________________________________________________________
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Решение
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32 (Console.ReadLine());
// Console.Write(1);
// for(int result=2;result<=num;result++)
// {
//         Console.Write(","+ result*result*result);
// }

// или

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32 (Console.ReadLine());
// int result=1;
// Console.Write(result);
// while(result<num)
// {
//     result++;
//     Console.Write(","+result*result*result);
// }