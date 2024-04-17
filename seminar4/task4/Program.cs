void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");    
    int[] array = GenerateArray(arraySize, 0, 100);
    PrintArray(array);
    Console.WriteLine(CountPrime(array));
}

int CountPrime(int[] array)
{
    int count = 0;

    foreach (int number in array)
    {
        if(isPrime(number))
            count++;
    }
    return count;
}

bool isPrime(int number)
{
    if(number <2) return false;

    for(int i = 2; i < Math.Sqrt(number); i++)
    {
        if(number % i == 0)
        {
            return false;
        }
    }
    return true;
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

