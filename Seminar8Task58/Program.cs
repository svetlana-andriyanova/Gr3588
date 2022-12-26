// Программа, которая перемножает два двумерных массива.

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] firstArr2D = Fill2DArray(row, column, 0, 9); 
int[,] secondArr2D = Fill2DArray(row, column, 0, 9);
PrintData("Первый массив");
Print2DArray(firstArr2D);
PrintData("\nВторой массив");
Print2DArray(secondArr2D);
int[,] resultMatrix = MultipMatrix(firstArr2D, secondArr2D);
PrintData("\nПеремноженный массив");
Print2DArray(resultMatrix);

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
// Метод перемножения двух матриц
int[,] MultipMatrix(int[,] matrix1, int[,] matrix2)
{

    int[,] multMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                multMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return multMatrix;
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
// Метод вывода данных в консоль
void PrintData(string res)
{
    Console.WriteLine(res);
}