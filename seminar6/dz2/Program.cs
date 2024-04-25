//Задача 2: Задайте строку, содержащую латинские буквы
//в обоих регистрах. Сформируйте строку, в которой все
//заглавные буквы заменены на строчные. 

void Main()
{
    int lengthString = ReadInt("Введите длину генерируемой строки: ");
    string normalString = GenerateString(lengthString);
    Console.WriteLine(normalString);
    string lowerString = normalString.ToLower();
    Console.WriteLine(lowerString);
}

string GenerateString(int lengthString)
{
    string str = "";
    Random rnd = new Random();
    for (int i = 0; i < lengthString; i++)
    {
        
            str += (char) rnd.Next(' ', '~' + 1);
       
    }
    return str;
}

int ReadInt(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

Main();