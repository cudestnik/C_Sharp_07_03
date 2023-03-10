// Напишите программу,которая принимает на вход цифру,
//обозначающую день недели, и проверяет является ли этот день выходным.
Console.WriteLine("Введите пожалуйста число: ");
int num = int.Parse(Console.ReadLine()!);


if (num >=6 && num <=7)
{
    Console.WriteLine("Да ");
}
else if (num >= 1 && num <=5)
{
    Console.WriteLine("Нет ");
}


