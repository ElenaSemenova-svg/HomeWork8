//  Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int GetNumber(string message)
{
int result = 0;
while (true)
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число! Повтороите ввод");
    } 
}
return result;
}


int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int counter = 1;
    int startColumn = 0;
    int endColumn = columns - 1;
    int startRow = 0;
    int endRow = rows - 1;
    while (startColumn <= endColumn && startRow <= endRow)
    {
        for (int i = startColumn; i <= endColumn; i++)
        {
            matrix[startRow, i] = counter;
            counter++;
        }
        startRow++;
        for (int j = startRow; j <= endRow; j++)
        {
          matrix[j, endColumn] = counter;
          counter++;  
        }
        endColumn--;
        for (int k = endColumn; k >= startColumn; k--)
        {
            matrix[endRow, k] =counter;
            counter++;
        }
        endRow --;
        for (int l = endRow; l >= startRow; l--)
        {
            matrix[l, startColumn] = counter;
            counter++;
        }
        startColumn++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
{
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int rows = GetNumber(" Введите количество строк матрицы:");
int columns = GetNumber(" Введите количество столбцов матрицы:");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
