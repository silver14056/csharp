// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.

// Вывод диапазона:
string str = "123456789";
// Console.WriteLine(str[..]);      весь диапазон: 123456789
// Console.WriteLine(str[4]);       элемент с индексом: 5
// Console.WriteLine(str[2..6]);    Диапазон элементов от 2-го(включительно) до 6(не включительно): 3456
// Console.WriteLine(str[..2]);     Диапазон от начала до 2-го не включительно: 12
// Console.WriteLine(str[6..]);     Диапазон от 6(включ) до конца: 789
//
//С помощью диапазонов можно копировать массивы диапазонами. Прикопировании диапазонами копируются данные а не ссылка. Создается новый массив
// int[] a1 = { 0, 1, 4, 3, 2 };
// int b1 = a1;
// a1[0] = 100;
// Console.WriteLine(string.Join(", ", a1); вывод: 100, 1, 4, 3, 2
// Console.WriteLine(string.Join(", ", b1); вывод: 100, 1, 4, 3, 2

// int[] a1 = { 0, 1, 4, 3, 2 };
// int b1 = a1[..];
// a1[0] = 100;
// Console.WriteLine(string.Join(", ", a1);    вывод: 100, 1, 4, 3, 2
// Console.WriteLine(string.Join(", ", b1);    вывод: 0, 1, 4, 3, 2
//
// Создается массив с соответствующим размером
// int b1 = a1[..];
// int b1 = a1[3..7];
// int b1 = a1[..7];
// int b1 = a1[3..];


void Main()
{
    Console.Write("Введите текст: ");
    string? str = Console.ReadLine();
    PrintCosonant(str);
}

void PrintCosonant(string str)
{
    if(str.Length < 1)
    {
        return;
    }
    char tempChar = char.ToLower(str[0]);
    if (isConsonant(tempChar))
    {
        Console.Write(str[0] + " ");
    }
    PrintCosonant(str[1..]);
}

bool isConsonant(char c)
{
    return "bcdfghjklmnpqrstvxzw".Contains(c);
}

Main();