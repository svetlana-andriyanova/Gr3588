// Программа, которая находит строку с наименьшей суммой элементов прямоугольного двумерного массива.

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 1, 9);
Print2DArray(arr2D);
if (RectangleTest(row, column))
{
    (int indexMinRow, int sumRow) = MinRow(arr2D);
    PrintData("Индекс минимальной строки: " + indexMinRow + "; Сумма строки равна: " + sumRow);
}

// Метод вывода данных в консоль
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
//Метод проверки прямоугольной матрицы
bool RectangleTest(int row, int column)
{
    if (row != column)
    {
        return true;
    }
    else Console.WriteLine("Задайте прямоугольную матрицу");
    return false;
}
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
// Метод поиска индекса минимальной строки
(int minIndex, int sumRow) MinRow(int[,] matrix)
{
    int minIndex = -1;
    int sumMinRow = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sumMinRow > sum)
        {
            sumMinRow = sum;
            minIndex = i;
        }
    }
    return (minIndex, sumMinRow);
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