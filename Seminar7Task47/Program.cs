// Программа задает двумерный массив размером m×n, заполненный случайными вещественными числами.
// При выводе матрицы показывает каждую цифру разного цвета(цветов всего 16)

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
double[,] arr2D = Fill2DArray(row, column);
Print2DColor(arr2D);

// Метод получения данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнения двумерного массива
double[,] Fill2DArray(int countRow, int countColumn)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.NextDouble();
            array2D[i, j] = Math.Round(array2D[i, j], 2);
        }
    }
    return array2D;
}

// Метод вывода двумерного массива в цветах
void Print2DColor(double[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray, ConsoleColor.Green,
                                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string num = matrix[i, j].ToString(); // Преобразуем число в строку
            for (int n = 0; n < num.Length; n++)  
            {
                Console.ForegroundColor = col[new System.Random().Next(0, 16)]; 
                Console.Write(num[n]); // Выводим каждый символ рандомным цветом
                Console.ResetColor();
            }
            Console.Write("      ".Substring(matrix[i, j].ToString().Length));

        }
        Console.WriteLine();
    }
}