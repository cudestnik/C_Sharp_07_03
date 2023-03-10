// Напишите программу, которая будет принимать на вход два числа 
//и выводить, является ли второе число кратным первому. Если число второе не кратно
// первому числу, то программа выводит остаток от деления....

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

if(num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не Кратно " + num1%num2);
}






