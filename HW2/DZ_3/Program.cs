// Напишите программу, которая выводит третью цифру данного
// числа или сообщает, чтто третьей цифры нет.

int num = new Random().Next(10, 1000);

Console.WriteLine(num);
int result = 0;
if (num < 999 && num > 99)
{
    result = num % 10;
    Console.WriteLine(result);
}
else if (num < 100)
{
    Console.WriteLine("Третьей цифры нет ");
}
