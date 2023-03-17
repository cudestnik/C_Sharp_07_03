// Задача 1. Напишите цикл ,который принимает на вход два числа (А и В )
// и возводит число А в натуральную степень В.
int num1 = 0;
int num2 = 0;

Console.Write("Введите пожалуйста число A = ");
num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите пожалуйста число B = ");
num2 = int.Parse(Console.ReadLine()!);
int result = 1;


for (int i = 1; i <= num2; i++)
{

   result = result * num1;
    
      
}   
    Console.WriteLine(result);

Console.ReadKey();
