
int[] testarr = GenArray(123, -100, 100);
Print1DArr(testarr);
int result = CountElements(testarr, 10, 99);
PrintData("Количество элементов массива в промежутке от 10 до 99 составляет: "+ result);

// Метод генерации массива
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);

    }
    return arr;
}

void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод вывода данных
void PrintData(string res)
{
    Console.WriteLine(res);

}

int CountElements(int[] arr, int min, int max)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > min && arr[i] < max)
        {
            res++;
        }
    }

    return res;
}