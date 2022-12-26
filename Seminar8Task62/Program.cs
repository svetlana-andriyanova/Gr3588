// Программа, которая заполняет спирально массив (квадратный и прямоугольный)

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] spiral2DArr = GenSpirArr(row, column);
Print2DArray(spiral2DArr);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

//Метод заполнения двумерного массива по спирали
int[,] GenSpirArr(int row, int column)
{
    int[,] arr = new int[row, column];
    int startI = 0, endI = 0, startJ = 0, endJ = 0;
    int k = 1, i = 0, j = 0;

    while (k <= row * column)
    {
        arr[i, j] = k;
        if (i == startI && j < column - endJ - 1)
            j++;
        else if (j == column - endJ - 1 && i < row - endI - 1)
            i++;
        else if (i == row - endI - 1 && j > startJ)
            j--;
        else
            i--;

        if ((i == startI + 1) && (j == startJ) && (startJ != column - endI - 1))
        {
            startI++;
            endI++;
            startJ++;
            endJ++;
        }
        k++;
    }
    return arr;
}
