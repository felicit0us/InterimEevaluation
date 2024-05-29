// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNaturalNumbers(int start, int end)
{
    if (start > end)
    {
        return;
    }

    Console.Write(start + " ");
    PrintNaturalNumbers(start + 1, end);
}

int DetectMin(int a, int b)

{
    int min = a;
    if (a > b)
    {
        min = b;
    }
    return min;
}

int DetectMax(int a, int b)

{
    int max = b;
    if (a > b)
    {
        max = a;
    }
    return max;
}

Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа в промежутке от {DetectMin(M, N)} до {DetectMax(M, N)}:");
PrintNaturalNumbers(DetectMin(M, N), DetectMax(M, N));
