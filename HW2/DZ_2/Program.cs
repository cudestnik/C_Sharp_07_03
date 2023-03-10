// Напишите программу, которая выводит случайное трехзначное число 
//и удалаяет вторую цифру этого числа.

int num = new Random().Next(100, 1000);

Console.WriteLine(num);
int result = 0;

result = ((num /100 )*10) + (num %10);

Console.WriteLine(result);

