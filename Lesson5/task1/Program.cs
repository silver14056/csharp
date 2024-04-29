//вычисляем факториал с помощью рекурсии

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n) ;
    int f = Fact(n - 1);
    Console.WriteLine($"Возврат:n={n}, f={f}");
    return n * f;
}

Console.WriteLine(Fact(2));