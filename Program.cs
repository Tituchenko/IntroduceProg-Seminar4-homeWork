﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.Write ("Введите число A:");
int A=int.Parse(Console.ReadLine()!);

Console.Write ("Введите число B:");
int B=int.Parse(Console.ReadLine()!);

Console.WriteLine ($"{A} в степени {B} = {power(A,B)}");

int power (int a, int b)
{
    int result=a;
    for (int i =1; i<b;i++)
    {
        result=result*a;
    }
    return result;
}
