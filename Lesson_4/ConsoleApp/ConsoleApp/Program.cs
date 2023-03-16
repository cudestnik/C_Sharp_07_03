/* Следующий этап. Нам нужно написать метод, который будет упорядочивать наш массив.
Назовём его selectionSort. В качестве аргумента точно таким же образом, как и в методе
выше, будет приходить некий массив array. Теперь писать, значит, нам нужно в первую
очередь пробежаться по всем элементам нашего массива. Чтобы не нарушать общность,
сделаем определение обращение к длине нашего массива через array.Length. Но здесь есть
отдельная особенность, о которой мы чуть-чуть позже поговорим.*/



int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
    {
    int count = array.Length;
for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
    }
Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0 ; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
           
        }
        int temporary = array[i];
    array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);