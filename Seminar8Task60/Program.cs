//Программа формирует трёхмерный массив из неповторяющихся двузначных чисел и построчно выводит массив, 
//добавляя индексы каждого элемента.


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int list = ReadData("Введите количество листов ");

// Список двухзначных чисел
List<int> num = new List<int>();
for (int i = 0; i < 90; i++)
{
    num.Add(10 + i);
}

int[,,] arr3D = Fill3DArray(row, column, list);
Print3DArray(arr3D);

// Метод считывания данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод генерации случайных уникальных чисел
int GenUniqNum(List<int> num)
{
    int index = new Random().Next(0, num.Count);
    int outNum = num[index];
    num.RemoveAt(index);
    return outNum;
}

// Универсальный метод генерации и заполнение трехмерного массива
int[,,] Fill3DArray(int countRow, int countColumn, int countList)
{

    int[,,] array3D = new int[countRow, countColumn, countList];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int z = 0; z < countList; z++)
            {
                int rand = GenUniqNum(num);
                array3D[i, j, z] = rand;
            }
        }
    }
    return array3D;
}

//Метод вывода трехмерного массива
void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write(matrix[i, j, z] + " ({0} {1} {2})  ", i, j, z);
            }
            Console.WriteLine();
        }
    }
}