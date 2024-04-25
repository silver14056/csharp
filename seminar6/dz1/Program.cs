//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
void Main()
{
    int row = ReadInt("Введите колличество строк: ");
    int column = ReadInt("Введите колличество столбцов: ");
    char[,] chars = GenerateCharMatrix(row, column);
    PrintMatrix(chars);
    Console.WriteLine(CharMatrixToString(chars));
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

char[,] GenerateCharMatrix(int row, int column)
{
    char[,] chars = new char[row, column];
    Random rnd = new Random();
    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            chars[i, j] = (char) rnd.Next('a', 'z' + 1);
        }
    }
    return chars;
}

void PrintMatrix(char[,] chars)
{
    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            Console.Write(chars[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

string CharMatrixToString(char[,] chars)
{
    string str = "";
    foreach (char letter in chars)
    {
        str += letter;
    }
    return str;
}

Main();