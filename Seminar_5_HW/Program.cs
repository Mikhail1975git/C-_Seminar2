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
