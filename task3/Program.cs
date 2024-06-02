// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArrayfromlast(int indx, int[] array)
{
    if (indx == 0) return;
    Console.Write($"{array[indx - 1]} ");
    PrintArrayfromlast(indx - 1, array);
}

int[] arr = CreateArrayRndInt(10, 0, 99);
Console.WriteLine();
PrintArrayfromlast(arr.Length, arr);