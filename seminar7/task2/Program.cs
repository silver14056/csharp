//Напишите программу, которая будет принимать на вход число и 
//возвращать сумму его цифр. Использовать рекурсию

void Main()
{
    int number = ReadInt("Введите число: ");
    Console.WriteLine(SumOfDigits(number));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits(int N)
{
    if (N < 1) return 0;
    return N % 10 + SumOfDigits(N / 10);
}

Main();