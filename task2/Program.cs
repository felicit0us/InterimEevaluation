// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


Console.WriteLine("Введите значение n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({n}, {m}) = {Ackermann(n, m)}");

int Ackermann(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ackermann(n - 1, 1);
    }
    else
    {
        return Ackermann(n - 1, Ackermann(n, m - 1));
    }
 }