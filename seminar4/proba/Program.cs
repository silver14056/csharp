void Main()
{
    while (true)
    {
        Console.Write("Введите целое число или q для выхода: ");
        string input = Console.ReadLine();

        if (input.ToLower().Equals('q'))
        {
            break;
        }

        int number;
        if (!int.TryParse(input, out number))
        {
            Console.WriteLine("Некорректный ввод! ");
            continue;
        }
               

        if (GetSumDigits(number) % 2 == 0)
        {
            Console.WriteLine("Сумма цифр {0} четная. Программа завершается.", number);
            break;
        }
    }


    int GetSumDigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number);
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}

Main();
