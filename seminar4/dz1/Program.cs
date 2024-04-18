void main()
{
    //получение строки
    //проверка на Q
    //первевод строки в число
    //проверка суммы на чЁтное
    
    
    string stopChar = "q";
    string stopMessage = "[STOP]";
    string startMessage = "Вводите числа: ";

    Console.WriteLine(startMessage);

    

    while (true)
    {
        
        

        if (strNumber == stopChar)
        {
            Console.WriteLine("[STOP]");
            return;
        }

        int num = Convert.ToInt32(strNumber);
        int sum = 0;

        while (num != 0)
        {
            sum += num % 10;
            num /= 10;

            
        }
        Console.WriteLine(sum);

        if (sum % 2 == 0)
        {
            Console.WriteLine("[STOP]");
            return ;
        }
    }
}



string ReadString(string msg)
{
    return Console.ReadLine();
}

main();
