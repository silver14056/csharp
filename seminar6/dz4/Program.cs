// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

void Main()
{
    string normalString = " one two three four five six seven eight nine ten ";
    string reverseString = reverseWordString(normalString);
    System.Console.WriteLine();
    System.Console.WriteLine($"|{reverseString}|");
}

string reverseWordString(string str)
{
    string temp = "";
    string rstr = "";

    for (int i = 0; i < str.Length; i++)
    {
        if(str[i].Equals(' '))
        {                        
            rstr = temp + rstr;
            rstr = str[i] + rstr;
            temp = "";
        }
        else
        {
            temp += str[i];
        }
        
    }
    rstr = temp + rstr;
    return rstr;
}


Main();