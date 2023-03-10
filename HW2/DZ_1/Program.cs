// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

int num = int.Parse(Console.ReadLine()!);

int result = 0;

result = ((num % 100) / 10);

    Console.WriteLine(result);


