
int[] testarr = GenArray(20, 1, 100);
Console.WriteLine("Исходный массив");
Print1DArr(testarr);

int[] copyArr = SwapNewArr(testarr);
Console.WriteLine("Перевернутый массив первым методом");
Print1DArr(copyArr);
Console.WriteLine("Исходный массив");
Print1DArr(testarr);

int[] copyNewArr = SwapArr(testarr);
Console.WriteLine("Перевернутый массив вторым методом");
Print1DArr(copyNewArr);
Console.WriteLine("Исходный массив");
Print1DArr(testarr);

// Метод генерации массива
int[] GenArray(int len, int minValue, int maxValue)
{

    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Метод вывода одномерного массива
void Print1DArr(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int[] SwapArr(int[] arr)
{
    int bufElement = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = bufElement;
    }
    return arr;

}

int[] SwapNewArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }
    return outArr;
}