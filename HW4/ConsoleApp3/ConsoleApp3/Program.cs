// Задача 3. Напишите программу, которая задаёт массив из 8 элементов
// случайными числами и выводит  их на экран. 
// Оформите заполнение массива и вывод ввиде функции (Пригодится в следующих задачах)

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(50, 100);
    Console.Write(randomArray[i] + " ");
}


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.ReadKey();