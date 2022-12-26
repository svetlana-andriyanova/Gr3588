// Программа упорядочивает по убыванию элементы каждой строки двумерного массива.

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DArray(row, column, 1, 9);
Print2DArray(arr2D);
Console.WriteLine();
int[,] sortArray = SortRow(arr2D);
Print2DArray(sortArray);

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
// Метод сортировки по строкам двумерного массива
int[,] SortRow(int[,] matrix)
{
    int[] arrRow = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {int k = 0;
        int m = 0;
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arrRow[k] = matrix[i, j];
            k++;
        }
        int[] sortArr = BubbleSort(arrRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = sortArr[m];
            m++;
        }
    }
    return matrix;
}
//Сортировка пузырьковым методом
int[] BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
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