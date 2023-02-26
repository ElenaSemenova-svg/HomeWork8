// // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] InitMatrix()
{
    int[,] matrix = new int[4, 4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] MultiArray(int[,] firstMatrix, int [,] secondMatrix)
{
    int [,] multiMatrix = new int[firstMatrix.GetLength(0),firstMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
     for (int j = 0; j < firstMatrix.GetLength(1); j++)
     {
        multiMatrix [i,j] = firstMatrix[i,j]*secondMatrix[i,j]; 
     }   
    }
    return multiMatrix;
}

int[,] firstMatrix = InitMatrix();
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = InitMatrix();
PrintMatrix(secondMatrix);
Console.WriteLine();
int [,] multiMatrix = MultiArray(firstMatrix, secondMatrix);
PrintMatrix(multiMatrix);
