void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 100, 999);
    PrintArray(array);
    PrintArray(FlipArray(array));
}

int[] FlipArray(int[] arr)
{
    int[] flipArr = new int[arr.Length];

    for(int i = 0; i < flipArr.Length; i++)
    {
        flipArr[i] = arr[arr.Length - 1 - i];
    }

    return flipArr;
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
