void main()
{
    //получение строки
    //проверка на Q
    //первевод строки в число
    //проверка суммы на чЁтное


    string stopChar = "q";
    string stopMessage = "[STOP]";
    string startMessage = "Введите число";

    while (true)
    {
        Console.WriteLine($"{startMessage} или {stopChar} для выхода: ");
        string strNumber = Console.ReadLine();

        if (strNumber.Equals(stopChar))
        {
            Console.WriteLine(stopMessage);
            return;
        }

        int number = Convert.ToInt32(strNumber);

        if (sumNambers(number) % 2 == 0)
        {
            Console.WriteLine(stopMessage);
            return;
        }
    }
    

    int sumNambers(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}


main();
