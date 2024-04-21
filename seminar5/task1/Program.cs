void Main()
{
    int row = ReadInt("Введите колличество строк: ");
    int column = ReadInt("Введите колличество стоьбцов: ");
    int[,] myMatrix = GenerateMatrix(row, column, 0, 9);
    PrintMatrix(myMatrix);
    ChangeMatrix(myMatrix);
    PrintMatrix(myMatrix);
}

int ReadInt (string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int minRange, int maxRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for(int i = 0; i < tempMatrix.GetLength(0); i++)
        for(int j = 0; j < tempMatrix.GetLength(1); j++)
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

void ChangeMatrix(int[,] matrix)
{
    for(int i = 0;i < matrix.GetLength(0); i += 2)
    {
        for(int j = 0;j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

Main();