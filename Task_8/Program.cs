﻿// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Привет, напиши число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count<N)
    {    
    if (count%2==0)
    Console.WriteLine(count);
    count++;    
    }