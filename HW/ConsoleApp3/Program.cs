// Задача 3. Напишите программу, которая наа вход принимает
//число и выдаёт, является ли чмсло четным(делится ли оно на 2 без остатка)

int num = 0;

Console.WriteLine("Введите пожалуйста число:");
num = int.Parse(Console.ReadLine()!);

if(num % 2 ==0)
{
    Console.WriteLine("Число чётное!");
}
else
{
    Console.WriteLine("Чиссло нечётное!");
}

