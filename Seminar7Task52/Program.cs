//Программа находит среднее арифметическое элементов в каждом столбце двумерного массива

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");

int[,] arr2D = Fill2DArray(row, column, 10, 99);
PrintData("Исходный 2D массив");
Print2DArray(arr2D);

int [] avr = AvrColumn(arr2D);
PrintData("Среднее арифметическое столбцов");
Print1DArr(avr);

//Метод считывания данных пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод вывода данных в консоль
void PrintData(string msg)
{
    Console.WriteLine(msg );
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

// Метод вычисления ср. арифметического по столбцам
int[] AvrColumn(int[,] matrix)
{
    int[] avr = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < avr.Length; i++)
        {
            avr[j] += matrix[i, j];
        }
        avr[j] = avr[j] / matrix.GetLength(0);

    }
    return avr;
}

// Метод вывода одномерного массива
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "    ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод вывода двумерного массива
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