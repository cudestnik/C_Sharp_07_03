// Напишите программу, которая принимает на вход координаты двух
//точек и находит расстояние между ними в 2 D
//пространстве.

Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("y1 = ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("x2 = ");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("y1 = ");
int y2 = int.Parse(Console.ReadLine()!);

double Lenght (int x1,int y1, int x2,int y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)),3);
}
Console.Write(Lenght(x1, y1, x2, y2));
