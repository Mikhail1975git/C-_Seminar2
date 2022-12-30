// Домашнее задание к Семинару 8

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Решение задачи 54

// Console.WriteLine("Введите число строк массива");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число столбцов массива");
// int n = int.Parse(Console.ReadLine());



// int[,] GetArray()
// {
//     int[,] matrix=new int [m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]=new Random().Next(20);
                    
//         }
//     } 
//     return matrix;
// }

// void ChangeArray(int[,] matrix)
// {
//     int temp=int.MinValue;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//             int count=0; 
//             while (count<=n)
//             {
                                          
//                 for (int j = 0; j < matrix.GetLength(1)-1; j++)
//                 {
                    
//                     if (matrix[i,j]<matrix[i,j+1])
//                     {
//                         temp=matrix[i,j];
//                         matrix[i,j]=matrix[i,j+1];
//                         matrix[i,j+1]=temp;
                                                                                 
//                     }
                
//                 }
//             count++;
//             }
//     }
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
        
//         {
//             Console.Write(matrix[i,j]+"\t");
                        
//         }
//     Console.WriteLine();
//     } 
// }
// int[,] array=GetArray();
// PrintArray(array);
// Console.WriteLine();
// ChangeArray(array);
// PrintArray(array);

//_______________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

//Решение задачи 56

// Console.WriteLine("Введите число строк массива");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число столбцов массива");
// int n = int.Parse(Console.ReadLine());



// int[,] GetArray()
// {
//     int[,] matrix=new int [m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]=new Random().Next(20);
                    
//         }
//     } 
//     return matrix;
// }

// void ChangeArray(int[,] matrix)
// {
//     int tempmin=int.MaxValue;
//     int tempminindex=0;
//     int count=0;
//     int i = 0;
//     for (i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         count=0;                              
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             count+=matrix[i,j];                                                             
                           
//         }
//         if (count<tempmin)
//         {
//             tempmin=count;
//             tempminindex=i+1;
//         }
            
            
//     }

// Console.WriteLine();
// Console.Write("Номер строки с наименьшей суммой элементов:"+tempminindex+"\t"+"Количество элементов:"+tempmin);
// Console.WriteLine();
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
        
//         {
//             Console.Write(matrix[i,j]+"\t");
                        
//         }
//     Console.WriteLine();
//     } 
// }
// int[,] array=GetArray();
// PrintArray(array);
// Console.WriteLine();
// ChangeArray(array);

//__________________________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Решение задачи 58

// Console.WriteLine("Введите число строк массива");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число столбцов массива");
// int n = int.Parse(Console.ReadLine());

// int[,] GetArray()
// {
//     int[,] matrix=new int [m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]=new Random().Next(1,10);
                    
//         }
//     } 
//     return matrix;
// }

// void MultiplyArray(int[,] array, int[,] array_2, int[,] array_res)
// {
//     if (array.GetLength(0)==array_2.GetLength(1))
//     {
//         int temp=0;
    
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
                                
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
                
//                 array_res[i,j]=0;
//                 for (int x = 0; x < array.GetLength(0); x++)
//                 {
//                     array_res[i,j]+=array[i,x]*array_2[x,j];
//                 }
                
            
//             }
//         }
//      }
//      else
//      {
//         Console.WriteLine("массивы перемножить нельзя!");
//      }

// Console.WriteLine();

// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
        
//         {
//             Console.Write(matrix[i,j]+"\t");
                        
//         }
//     Console.WriteLine();
//     } 
// }
// int[,] array=GetArray();
// int[,] array_2=GetArray();
// int[,] array_res=GetArray();
// PrintArray(array);
// Console.WriteLine();
// PrintArray(array_2);
// Console.WriteLine();
// MultiplyArray(array, array_2, array_res);
// PrintArray(array_res);
// Console.WriteLine();

//______________________________________________________________________________

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int[,,] Get3DArray()
// {
//     int[,,] matrix=new int[2,2,2];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int x = 0; x < matrix.GetLength(2); x++)
//             {
//                matrix[i,j,x]=new Random().Next(10,100); 
//             }
//         }
//     } 
//     return matrix;
// }


// void Print3DArray(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
        
//         {
//             for (int x = 0; x < matrix.GetLength(2); x++)
//             {
//                 Console.Write(matrix[i,j,x]+"("+i+","+j+","+x+")"+"\t");
//             }
//         Console.WriteLine();               
//         }

//     }

// }
// int[,,] array=Get3DArray();

// Print3DArray(array);
// Console.WriteLine();



//______________________________________________________________

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] Get4x4Array()
// {
//     int[,] matrix=new int [4, 4];
//     int temp = 1;
//     int i = 0;
//     int j = 0;

//     while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
//     {
//     matrix[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= matrix.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > matrix.GetLength(1) - 1)
//         j--;
//     else
//         i--;
//     }
// return matrix;
// }



// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
        
//         {
//             Console.Write(matrix[i,j]+"\t");
                        
//         }
//     Console.WriteLine();
//     } 
// }
// int[,] array=Get4x4Array();
// PrintArray(array);
// Console.WriteLine();

//_____________________________________________________________