// Напишите программу, которая на вход принимает
//пятизначное число  и проверяет, является ли оно палиндромом.
int num = int.Parse(Console.ReadLine()!);

int result_1 = 0;

int result_2 = 0;

int result_3 = 0;

int result_4 = 0;


result_1 = (num / 10000);
result_2 = ((num / 1000) % 10);
result_3 = ((num % 100)/10);
result_4 = ((num % 10));

if(result_1 == result_4 && result_2 == result_3)
{
    Console.WriteLine("Да ");
}
else
{
    Console.WriteLine("Нет ");
}
