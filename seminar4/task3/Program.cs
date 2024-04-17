void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");

    if (arraySize > 8 )
    {
        Console.WriteLine("Вы ввели слишком большое число!");
        return;
    }

    int[] array = GenerateArray(arraySize, 0, 9);
    PrintArray(array);
    Console.WriteLine(FromArrayToNumber(array));
    
}

int FromArrayToNumber(int[] array)
{
    // Решение с помощью цикла FOR
    //int number = 0;
    //for (int i = 0; i < array.Length; i++)
    //{
    //    number = number * 10 + array[i];
    //}

    // Решение с помощью метода string.Concat()
    return Convert.ToInt32(string.Concat(array));

    // Решение с помощью цикла FOREACH
    //int number = 0;
    //foreach (int value in array)
    //{
    //    number = number * 10 + value;
    //}
    //return number;
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
    //for (int i = 0; i < arrayForPrint.Length; ++i)
    //{
    //    Console.Write(arrayForPrint[i] + " ");
    //}
    //Console.WriteLine();

    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}


Main();
