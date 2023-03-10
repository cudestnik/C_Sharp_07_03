//Напишите программу, которая принимает на вход число и проверяет 
// кратно ли оно одновременно 7 и 23?




int num = int.Parse(Console.ReadLine()!);

void MyFunc(int num)
{

    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не Кратно ");
    }

}

MyFunc(num);
