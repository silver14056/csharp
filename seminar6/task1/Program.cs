//создать строку из символов масиива

void Main()
{
    
    char[] chars = { 'a', 'b', 'c',  'd' };

    //1-й вариант
    //string str = new string(chars);
    //Console.WriteLine(str);

    //2-й вариант
    //string str = ArrayToString(chars);

    //3-й вариант
    //string str = string.Concat(str);

    //4-й вариант(не сильно правильно его применять)
    string str = string.Join("", chars);
    Console.WriteLine(str);
}

string ArrayToString(char[] chars)
{
    string str = "";
    foreach (char letter in chars)
    {
        str += letter;
    }
    return str;
}

Main();
