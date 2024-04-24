//Задача 4*(не обязательная): Задайте двумерный массив
//из целых чисел. Напишите программу, которая удалит
//строку и столбец, на пересечении которых расположен
//наименьший элемент массива. Под удалением
//понимается создание нового двумерного массива без
//строки и столбца

void Main()
{
    int row = ReadInt("Введите колличество строк: ");
    int column = ReadInt("Введите колличество столбцов: ");
    int[,] myMatrix = GenerateMatrix(row, column, 0, 9);    
    PrintMatrix(myMatrix);
    int[,] newMatrix = CreateMatrixWithoutMin(myMatrix, FindMinElement(myMatrix));
    PrintMatrix(newMatrix);

    
    
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

int[] FindMinElement(int[,] matrix)
{
    int a = 0;
    int b = 0;

    for(int i = 0;i < matrix.GetLength(0); i++)
    {
        for(int j = 0;j < matrix.GetLength(1); j++)
        {
            if (matrix[a, b] > matrix[i, j])
            {
                a = i;
                b = j;
            }
        }
    }
    Console.WriteLine($"Индекс минимального элемента матрицы [{a},{b}]");
    Console.WriteLine();
    int[] indexMinElement = new int[2] {a, b};
    return indexMinElement;
}

int[,] CreateMatrixWithoutMin(int[,] matrix, int[] indexs)
{
    int[,] matrixWithoutMin = new int[matrix.GetLength(0) -1, matrix.GetLength(1) -1];
    int a = 0;
    int b = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == indexs[0])
        {
            continue;
        }
        for (int j = 0; j < matrix.GetLength(1);j++)
        {
            if (j == indexs[1])
            {
                continue;
            }
            matrixWithoutMin[a, b] = matrix[i, j];
            b++;
        }
        a++;
        b = 0;        
    }
    return matrixWithoutMin;
}



Main();
