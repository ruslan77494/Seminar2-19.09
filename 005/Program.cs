﻿/*
Напишите программу,
 которая принимает на вход два числа и проверяет,
  является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

Console.WriteLine(" Пожалуйста Введите Первое Число:   ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Пожалуйста Введите Второе Число:   ");
int n1 = Convert.ToInt32(Console.ReadLine());

if ((n * n == n1) || (n1 * n1 == n)) 
    Console.WriteLine("то +");
else
 {
    Console.WriteLine("то -");
 }
