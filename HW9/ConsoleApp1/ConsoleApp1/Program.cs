/*
 Задача 1 Задайте значения N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от N до 1.

 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }

    if (count > n)
        return;
    if (n % 2 == 0)
    {
        return;
    }
   
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}

