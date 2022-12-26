// Метод считывания данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Метод поиска минимального элемента
(int x, int y) SearchMinEL(int[,] matrix)
{
    int row = 0;
    int column = 0;
    int min = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                row = i;
                column = j;
            }
        }

    }
    return (row, column);
}

int[,] Convert2DArray(int [,] matrix, int x, int y)
{
    int[,] outArr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int k = 0;
    int m = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         m = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != x && j != y)
            {
                outArr[k, m] = matrix[i, j];
            }
            if (j != y) m++;
        }
        
            if (i != x) k++;
        
    }
    return outArr;
}

//Метод вывода двумерного массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "      ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 0, 99);
Print2DArray(arr2D);
Console.WriteLine();
(int x, int y) minElem = SearchMinEL(arr2D);
int[,] out2D = Convert2DArray(arr2D, minElem.x, minElem.y);

Print2DArray(out2D);