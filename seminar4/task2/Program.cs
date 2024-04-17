void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 20, 23);
    PrintArray(array);
    Console.WriteLine(CountNumbers(array, 7, 1));    
}

int CountNumbers(int[] myArray, int div, int end)
{
    int count = 0;
    foreach (int number in myArray)
    {
        if(number % div == 0 && number % 10 == end)
        {
            count++;
        }
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
        tempArray[i] = rand.Next(minRange, maxRange);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; ++i)
    {
        Console.Write(arrayForPrint[i] + " ");
    }
    Console.WriteLine();
}

Main();
