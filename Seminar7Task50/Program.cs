//Программа на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Программа заполняет массив числами Фиббоначи и выделяет цветом найденную цифру

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Fill2DFib(row, column);
Print2DArray(arr2D);
int posInRow = ReadData("Введите позицию элемента в строке ");
int posInColumn = ReadData("Введите позицию элемента в столбце ");
SearchElement(arr2D, posInRow, posInColumn);

//Метод получения данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива числами Фибоначчи
int[,] Fill2DFib(int countRow, int countColumn)
{
    int[,] array2D = new int[countRow, countColumn];

    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            if ((i == 0) && (j == 0))
            { array2D[i, j] = 0; }
            else
            if ((i == 0) && (j == 1))
            { array2D[i, j] = 1; }
            else
                array2D[i, j] = (first + last);
            buf = first;
            first = last;
            last = last + buf;
        }

    }
    return array2D;
}

//Метод поиска позиции элемента
void SearchElement(int[,] matrix, int x, int y)
{
    int element = 0;
    if ((x <= matrix.GetLength(0)) && (y <= matrix.GetLength(1)))
    {
        element = matrix[x - 1, y - 1]; // Если позицию вводят относительно 1, если относительно 0, то  element = matrix[x1, y-1]
        Print2DArrPosElement(matrix, element);
    }
    else PrintData("Такого элемента нет ");

}

// Метод вывода двумерного массива
void Print2DArrPosElement(int[,] matrix, int element)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == element)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(matrix[i, j] + "      ".Substring(matrix[i, j].ToString().Length));
                Console.ResetColor();
            }
            else
                Console.Write(matrix[i, j] + "      ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
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

// Метод вывода данных в консоль
void PrintData(string res)
{
    Console.WriteLine(res);
}