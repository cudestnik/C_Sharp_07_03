// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 





Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double numberX = (b2 - b1) / (k1 - k2);
double numberY = k2 * numberX + b2;

Console.WriteLine($"Точка пересечения двух прямых: {numberX},{numberY}");