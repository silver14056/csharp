void Main()
{
    int row = ReadInt("Введите колличество строк: ");
    int column = ReadInt("Введите колличество столбцов: ");
    int[,] myMatrix = GenerateMatrix(row, column, 0, 9);
    PrintMatrix(myMatrix);
    PrintArray(FindAverage(myMatrix));
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int minRange, int maxRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
            tempMatrix[i, j] = rand.Next(minRange, maxRange + 1);

    return tempMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] FindAverage(int[,] matrix)
{
    double[] averages = new double[matrix.GetLength(0)];

    for (int i = 0;i < matrix.GetLength(0);i++)
    {
        for(int j = 0;j < matrix.GetLength(1);j++)
        {
            averages[i] = averages[i] + matrix[i, j];
        }
        averages[i] = Math.Round(averages[i] / matrix.GetLength(1), 2);
    }
    return averages;

}

void PrintArray(double[] array)
{
    Console.WriteLine("[" + string.Join(" , ", array) + "]");
}

Main();

