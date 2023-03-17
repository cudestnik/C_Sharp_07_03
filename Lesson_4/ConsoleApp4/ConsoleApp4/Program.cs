// Напишите программу, которая выводит массив из 8 элементов,
// заполненый нулями и единицами в случайном порядке.

PrintArray(MakeArray());

int[] MakeArray();
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = GeneratNumber();
    }
    return arr;
}


int GeneratNumber()
    {

        int number = new Random().Next(2);
        return number;

    }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($" {array[i]} ");
    }
    Console.WriteLine();
}




