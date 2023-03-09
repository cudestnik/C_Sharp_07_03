// Напишите прогорамму, которая на вход принимает два числа
// и проверяет является ли первое число квадратом .
int num1 = 0;
int num2 = 0;

Console.WriteLine("Введите пожалуйста число 1 n1 = ");
num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите пожалуйста число 2 n2 = ");
num2 = int.Parse(Console.ReadLine()!);

if ((num2 * num2) == num1)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}