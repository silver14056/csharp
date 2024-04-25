//Считать строку с консол, состоящую из латинских
//ьукв в нижнем регистре. Выяснить, сколько среди
//введённых буквгласных.

void Main()
{
    Console.WriteLine("Введите текст: ");
    string? str = Console.ReadLine()?.ToLower();
    Console.WriteLine(CountVowels(str));


}

int CountVowels(string? str)
{
    int count = 0;

    foreach (char letter in str!)
    {
        if (isVowel(letter))
            count++;
    }
    return count;
}

bool isVowel(char c)
{
    return "aeiouy".Contains(c);
}

Main();