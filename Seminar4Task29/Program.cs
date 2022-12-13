// Программа, которая генерирует массив с заданной длиной и диапазоном чисел

int arrLen = ReadData("Введите длину массива ");
int minNum = ReadData("Введите нижнюю границу чисел ");
int maxNum = ReadData("Введите верхнюю границу чисел ");
int[] arr = GenArray(arrLen, minNum, maxNum);
PrintData("Сгенерированный массив:", arr);

// Метод получения данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0"); ;
}

// Метод вывода данных
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArray(arr); // Вызов метода вывода массива
}
// Метод генерации массива
int[] GenArray(int num, int minN, int maxN)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minN, maxN);
    }
    return arr;
}

// Метод вывода массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");

    }
    Console.Write(arr[arr.Length - 1] + "]");
}

