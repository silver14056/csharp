//Задача 3: Задайте произвольную строку. Выясните,
//является ли она палиндромом.

void Main()
{
    int lengthString = ReadInt("Введите длину генерируемой строки: ");
    string normalString = GenerateString(lengthString);
    Console.WriteLine(normalString);
    Console.WriteLine();
    Console.WriteLine(isPalindrom(normalString));
}

string GenerateString(int lengthString)
{
    string str = "";
    Random rnd = new Random();
    for (int i = 0; i < lengthString; i++)
    {

        str += (char)rnd.Next(' ', '~' + 1);

    }
    return str;
}

int ReadInt(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

string isPalindrom(string str)
{
    string yes = "Yes";
    string no = "No";

    for (int i = 0; i < str.Length / 2; i++)
    {        
        if (str[i].Equals(str[str.Length-1-i]))
        {
            
        }
        else
        {
            return no;
        }
    }
    return yes;
    
}

Main();