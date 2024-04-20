﻿int[,] matrix = CreateMatrix(4, 6);
ShowMatrix(matrix);

int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(IsEven(matrix[i, j]))
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
    }    
}
}

bool IsEven(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    if(sum % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}