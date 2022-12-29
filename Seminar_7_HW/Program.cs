// Домашнее задание к Семинару 7

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Решение задачи 47

// Console.WriteLine("Введите число строк");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число столбцов");
// int n = int.Parse(Console.ReadLine());

// double[,] matrix=new double [m, n];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
    
//     for (int j = 0; j < matrix.GetLength(1); j++)
    
//     {
//         matrix[i,j]=new Random().NextDouble() *10;  // не понятно, как ограничить цифру после запятой?
//         Console.Write(matrix[i,j]+" ");
//     } 
//     Console.WriteLine();
// }

//______________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// Решение задачи 50 

// Console.WriteLine("Введите число строк массива");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число столбцов массива");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите строку числа для проверки");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите столбец числа для проверки");
// int num2 = int.Parse(Console.ReadLine());

// int res1=-1;
// int res2=-1;

// int[,] matrix=new int [m, n];


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
    
//     for (int j = 0; j < matrix.GetLength(1); j++)
    
//     {
//         matrix[i,j]=new Random().Next(1,20);
//         Console.Write(matrix[i,j]+" ");
//         if (i==num1&&j==num2)
//         {
//             res1=i;
//             res2=j;
//         }
         
// } 
// Console.WriteLine();

// }
// if (res1<0)
// {
//     Console.WriteLine("такого элемента в массиве нет");
// }
// else
// {
//     Console.WriteLine("заданное число "+matrix[res1,res2]);
// }

// Решение задачи 50 - с принятием на вход числа для проверки наличия его в массиве, и выдачей его позиции 

// Console.WriteLine("Введите число строк массива");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число столбцов массива");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число для проверки");
// int x = int.Parse(Console.ReadLine());

// int num1=-1;
// int num2=-1;

// int[,] matrix=new int [m, n];


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
    
//     for (int j = 0; j < matrix.GetLength(1); j++)
    
//     {
//         matrix[i,j]=new Random().Next(1,20);
//         Console.Write(matrix[i,j]+" ");
//         if (matrix[i,j]==x)
//         {
//             num1=i;
//             num2=j;
//         }
         
// } 
// Console.WriteLine();

// }
// if (num1<0)
// {
//     Console.WriteLine("такого числа в массиве нет");
// }
// else
// {
//     Console.WriteLine("совпадает с индексом :"+"["+num1+", "+num2+"]");
// }

//_________________________________________________________________

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Решение задачи 52

// Console.WriteLine("Введите число строк массива");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число столбцов массива");
// int n = int.Parse(Console.ReadLine());

// double count=0;

// int[,] matrix=new int [m, n];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]=new Random().Next(1,20);
//         Console.Write(matrix[i,j]+" ");
            
//     }
//     Console.WriteLine();
// } 
// Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");

// for (int j = 0; j < matrix.GetLength(1); j++)
    
//     {
        
//         for (int i = 0; i < matrix.GetLength(0); i++)
        
//         {
//             count+=matrix[i,j];
//         }
//     Console.WriteLine("Столбец№"+(j+1)+"="+count/m+" ");
//     count=0;
//     } 
// Console.WriteLine();



//или с методами:

// Console.WriteLine("Введите число строк массива");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число столбцов массива");
// int n = int.Parse(Console.ReadLine());

// double count=0;

// int[,] matrix=new int [m, n];

// FillArray(matrix);

// PrintArray(matrix);

// Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");

// for (int j = 0; j < matrix.GetLength(1); j++)
    
//     {
        
//         for (int i = 0; i < matrix.GetLength(0); i++)
        
//         {
//             count+=matrix[i,j];
//         }
//     Console.WriteLine("Столбец№"+(j+1)+"="+count/m+" ");
//     count=0;
//     } 
// Console.WriteLine();

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]=new Random().Next(1,20);
        
//         }
//     } 
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < array.GetLength(1); j++)
        
//         {
//             Console.Write(array[i,j]+" ");
                        
//         }
//     Console.WriteLine();
//     } 
// }




