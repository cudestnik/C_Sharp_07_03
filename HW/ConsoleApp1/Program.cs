// Задача 1. Напишите программу, на вход принимает два числа 
// и выдает, какое число большее,а какое меньшее.


Console.WriteLine("Введите пожалуйста число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите пожалуйста число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine("Максимальное число: " + num1);
}
else if (num1 < num2)
{
    Console.WriteLine("Максимальное число: " + num2);
}
else if (num1 == num2)
{
    Console.WriteLine("Числа равны! ");
}
