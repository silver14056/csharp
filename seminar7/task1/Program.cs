// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от одного до N.
// Использовать рекурсию! Не использовать циклы

void Main()
{
    int number = ReadInt("Введите число: ");
    PrintNumbers(number);
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int N)
{
    if (N < 1) return;
    PrintNumbers(N - 1);
    Console.Write(N + " ");
    
}

Main();