﻿// Задача2. Напишите программу, которая принимает на
// вход число и выдает сумму всех цифр в числе.

int num = GetUserNumber();
int digits = MultiplyNumbers(num);
Console.WriteLine(digits);

int GetUserNumber()
{

    int number = 0;
    while (number == 0)
    {
        Console.Write("Пожалуйста введите число: ");
        number = int.Parse(Console.ReadLine()!);
    }
    return number;
}

int MultiplyNumbers(int n)
{

    int multi = 1;
    for (int i = 1; i <= n; i++)
    {
        multi = multi + i;
    }
    return multi;
}
Console.ReadKey();
