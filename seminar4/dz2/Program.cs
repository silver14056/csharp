void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 100, 999);
    PrintArray(array);
    Console.WriteLine(CountEven(array));
}

int CountEven(int[] array)
{
    int count = 0;

    foreach (int number in array)
    {
        if (number % 2 == 0)
            count++;
    }
    return count;
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; ++i)
    {
        tempArray[i] = rand.Next(minRange, maxRange + 1);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}


Main();


