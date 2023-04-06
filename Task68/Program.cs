//функции Аккермана

int f(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return f(m - 1, 1);
    }
    else
    {
        return f(m - 1, f(m, n - 1));
    }
}

Console.Clear();
Console.Write("Введите 1 число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));


