
//Семинар9 Домашнее задание
// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"  // 
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Решение задачи 64

// Console.WriteLine("Введите число");
// int n=Convert.ToInt32(Console.ReadLine());

// string PrintNumber (int start, int end)
// {
//     if (start==end)
//     {
//         return end.ToString();
//     }
//     return (start+" "+PrintNumber(start-1,end));
// }
// Console.WriteLine(PrintNumber(n,1));



// _________________________________________________________________________


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Решение задачи 66

// Console.WriteLine("Введите число 1");
// int m=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 2");
// int n=Convert.ToInt32(Console.ReadLine());
// int count=0;

// int PrintNumber (int start, int end)
// {
//     count=start;
//     if (start==end)
//     {
//         return count;
//     }
//     if (start>end)
//     {
//         Console.WriteLine("Число 1 больше числа 2");
//         return 0;
//     }
//     return (count+PrintNumber(start+1,end));
// }
// Console.WriteLine(PrintNumber (m,n));

// _________________________________________________________________________

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Решение задачи 68

// Console.WriteLine("Введите число 1");
// int n=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 2");
// int m=Convert.ToInt32(Console.ReadLine());


// int AkkermanFunction(int n, int m)
// {
//     if (n==0)
//     {
//         return m+1;
//     }
//     if ((n!= 0) && (m == 0))
//     {
//         return AkkermanFunction(n - 1, 1);
//     }
//     if ((n > 0) && (m > 0))
//     {
//         return AkkermanFunction(n - 1, AkkermanFunction(n, m-1));
//     }
    
// return AkkermanFunction(n,m);    
// }
// Console.WriteLine("Функция Аккермана для чисел A("+n+","+m+")="+AkkermanFunction(n,m));



// _________________________________________________________________________


