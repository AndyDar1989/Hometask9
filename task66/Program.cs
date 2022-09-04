﻿/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumBetweenIntegers(int m, int n)
{
    int sum;
    if (m < n) sum = n + SumBetweenIntegers(m, n - 1);
    else if (m > n) sum = m + SumBetweenIntegers(m - 1, n);
    else sum = m;
    return sum;
}

int result = SumBetweenIntegers(1, 1);
Console.WriteLine(result);
