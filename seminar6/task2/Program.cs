// Из строки сделать массив символов char и вывести на экран

using System.Diagnostics.SymbolStore;

void Main()
{
    Console.WriteLine("Введите текст: ");
    //чтобы не выводило предупреждение о том шо string может быть NULL, можно потавить вопросительный знак после типа переменной
    string? str = Console.ReadLine();

    //1-й вариант
    //ЧТобы компилятор не ругался на возможно нулевую строку, после имени переменной можно поставить <!>
    //char[] chars = str!.ToCharArray();

    //2-й вариант
    char[] chars = StringToCharArray(str);

    //3-й вариант

    PrintArray(chars);

}

char[] StringToCharArray(string? str)
{
    char[] Tempchars = new char[str!.Length];

    for (int i = 0; i < str.Length; i++)
    {
        Tempchars[i] = str[i];
    }
    return Tempchars;
}

void PrintArray(char[] chars)
{
    Console.WriteLine("[" + string.Join(", ", chars) + "]");
}

Main();