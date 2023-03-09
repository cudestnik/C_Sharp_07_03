// Задача 2. Напишите программу,которая принимает на вход три числа и выдаёт 
//максимальное из этих



int num1 = 0;
int num2 = 0;
int num3 = 0;


Console.WriteLine("Введите первое число: n1 = ");
num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: n2 = ");
num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: n3 = ");
num3 = int.Parse(Console.ReadLine()!);
int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine("Максимальное число: " + max);
