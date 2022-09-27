//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
/*
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
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12
Console.Write ("Введите число:");
string numberStr=Console.ReadLine()!; // даже переводить в int не будем, так проще

Console.WriteLine ($"Сумма цифр числа {numberStr} = {getSumOfNumber(numberStr)}");
Console.WriteLine ($"Сумма цифр числа {numberStr} = {getSumOfNumber2(numberStr)}");

int getSumOfNumber(string str)
{
    int result=0;
    for (int i=0;i<str.Length;i++)
    {
        result+= int.Parse(str[i].ToString()); // а теперь переведем, нам же сложить как числа. 
        //Отвратительная реализация int.Parse в C# - string можно, а char нельзя, хотя string по сути массив char -  абсолютно не логично!!
    }
    return result;
}

int getSumOfNumber2(string str) // так как мы "не проходили" проблему int.Parse решим другим способом
{
    int result=0;
    int temp=int.Parse(str);
    for (int i=0;i<str.Length;i++)
    {
        result+= temp%10; // последняя цифра
        temp=temp/10;// целлочисленное деление - без послденей цифры
    }
    return result;
}
