int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DIndexed(int row, int column)
{
    int[,] matrix = new int[row, column];
   
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write( matrix[i, j] + "   ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DIndexed(row, column);
Print2DArray(arr2D);