//Seminar_5

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

//Решение задачи 34

// Console.WriteLine("Введите длинну массива");
// int num = int.Parse(Console.ReadLine());
// int [] array= new int [num];
// int count=0;
// for (int i = 0; i < array.Length ; i++)
// {
//     array[i]=new Random().Next(100,1000);
//     if (array[i]%2==0)
//     {
//         count++;
//     }
// }
// Console.WriteLine("[{0}]", String.Join(",", array));
// Console.WriteLine("Количество чётных чисел в массиве ="+ count);

//______________________________________________________________________________________

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

//Решение задачи 36

// Console.WriteLine("Введите длинну массива");
// int num = int.Parse(Console.ReadLine());
// int [] array= new int [num];
// int count=0;
// for (int i = 0; i < array.Length ; i++)
// {
//     array[i]=new Random().Next(-100,100);
//     if ((i+1)%2==0)
//     {
//         count=count+array[i];
//     }
// }
// Console.WriteLine("[{0}]", String.Join(",", array));
// Console.WriteLine("Cумма элементов, стоящих на нечётных позициях ="+ count);



//______________________________________________________________________________________


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

//Решение задачи 38

// Console.WriteLine("Введите длинну массива");
// int num = int.Parse(Console.ReadLine());
// double [] array= new double [num];

// for (int i = 0; i < array.Length ; i++)
// {
//     array[i]=new Random().Next(-100,100);
// }
// Console.WriteLine("[{0}]", String.Join(",", array));

// double min=array[0];
// double max=array[0];
// double result=0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]>max)
//     {
//     max=array[i];
//     }
//     else if (array[i]<min)
//     {
//     min=array[i];
//     }
// }

// Console.WriteLine("Разница между максимальным и минимальным элементов массива ="+ (max-min));



//______________________________________________________________________________________



//Семинар 6

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.


// Console.WriteLine("Введите длину стороны A");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите длину стороны B");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите длину стороны C");
// int num3 = int.Parse(Console.ReadLine());

// if (num1+num2>num3&&num1+num3>num2&&num2+num3>num1)
// {
//     Console.WriteLine("Такой треугольник может быть");
// }
// else
// {
//     Console.WriteLine("Такого треугольника не может быть");
// }

//_______________________________________________________________________

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// string str = "";

// while (num>0)
// {
//     str=num%2+str;
//     num/=2;
// }

// Console.WriteLine(str);

//__________________________________________________

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int num1 = 0;
// int num2 = 1;
// Console.WriteLine(num1);
// Console.WriteLine(num2);

// for (int i = 3; i <= num; i++)
// {
//     int next=num1+num2;
//     Console.WriteLine(next);
//     num1=num2;
//     num2=next;
// }

//Задача 45: Напишите программу, 
//которая будет создавать копию заданного массива с помощью поэлементного копирования.


// Console.WriteLine("Введите длинну массива");
// int num = int.Parse(Console.ReadLine());
// int [] array= new int [num];
// int [] array2= new int [num];
// for (int i = 0; i < array.Length ; i++)
// {
//     array[i]=new Random().Next(-100,100);
//     array2[i]=array[i];
// }
// Console.WriteLine("[{0}]", String.Join(",", array));
// Console.WriteLine("[{0}]", String.Join(",", array2));

//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.WriteLine("Введите длинну массива");
// int num = int.Parse(Console.ReadLine());
// int [] array= new int [num];
// int [] array2= new int [num];
// for (int i = 0; i < array.Length ; i++)
// {
//     array[i]=new Random().Next(-100,100);
//     array2[array.Length-1-i]=array[i];
// }
// Console.WriteLine("[{0}]", String.Join(",", array));
// Console.WriteLine("[{0}]", String.Join(",", array2));

//вариант 2


// int [] array={1, 2, 3, 4, 5};

// for (int i = 0; i < array.Length/2 ; i++)
// {
//     int temp=array[i];
//     array[i]=array[array.Length-1-i];
//     array[array.Length-1-i]=temp;
// }
// Console.WriteLine("[{0}]", String.Join(",", array));

//______________________________________________________________________________

//дОМАШНЕЕ ЗАДАНИЕ к Семинару 6

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

//Решение задачи 41

// Console.WriteLine("Введите количество чисел для анализа");
// int M = int.Parse(Console.ReadLine());
// int [] array= new int [M];
// int count=0;
// for (int i = 0; i < M ; i++)
// {
//     Console.WriteLine("Введите число"+ (i+1));
//     array[i] = int.Parse(Console.ReadLine());
//     if (array[i]>0)
//     {
//         count++;
//     }
// }
// Console.WriteLine(String.Join(",", array));
// Console.WriteLine("чисел больше нуля = " + count);

// или 

// Console.WriteLine("Введите количество чисел для анализа");
// int M = int.Parse(Console.ReadLine());
// int i = 0;
// int count = 0;
// while (i < M )
// {
//     Console.WriteLine("Введите число");
//     int num = int.Parse(Console.ReadLine());
//     i++;

//     if (num>0)
//     {
//         count++;
//     }
// }

// Console.WriteLine("чисел больше нуля = " + count);


//______________________________________________________________________________________________

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Решение задачи 43

// //y = k1 * x + b1, y = k2 * x + b2
// //k1 * x + b1 = k2 * x + b2
// //(k1 - k2) * x = b2 - b1
// //x = (b2 - b1) / (k1 - k2)
// //y = k1 * x + b1

// Console.WriteLine("Задайте координату b1");
// double b1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Задайте координату k1");
// double k1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Задайте координату b2");
// double b2 = double.Parse(Console.ReadLine());

// Console.WriteLine("Задайте координату k2");
// double k2 = double.Parse(Console.ReadLine());
// double x = 0;
// double y = 0;

// if (k1==k2)
// {
//     Console.WriteLine("Прямые не пересекаются");
// }
// else
// {
// x = (b2 - b1) / (k1 - k2);
// y = k1 * x + b1;
// Console.WriteLine("(" + x + ";" + y + ")");
// }



// или (к сожалению работает только для примера в условии, 
// т.к. не хочет подбирать шаг для итерации x = x + 0.5;)


// Console.WriteLine("Задайте координату b1");
// double b1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Задайте координату k1");
// double k1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Задайте координату b2");
// double b2 = double.Parse(Console.ReadLine());

// Console.WriteLine("Задайте координату k2");
// double k2 = double.Parse(Console.ReadLine());

// double x = -100;

// while ( x < 100 )
// {
    
//     if ((k1 * x + b1) == (k2 * x + b2))
//     {
//         double y = k1 * x + b1;
//         Console.WriteLine("(" + x + ";" + y + ")");
//     }
//     x = x + 0.5;
// }


//______________________________________________________________________________________________