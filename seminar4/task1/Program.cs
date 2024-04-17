//void Main()
//{
//    Console.Write("Введите число: ");
//    int arraySize = Convert.ToInt32(Console.ReadLine());

//    int[] array = new int[arraySize];
//    Random rand = new Random();

//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = rand.Next(0, 10);
//    }

//    for (int i = 0; i < array.Length; ++i)
//    {
//        Console.Write(array[i] + " ");
//    }
//}

//Main();

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 10);
    PrintArray(array);

    int arraySize2 = ReadInt("Введите размер второго массива: ");
    int[] array2 = GenerateArray(arraySize2, 10, 1000);
    PrintArray(array2);
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

    for(int i = 0;i < size; ++i)
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
