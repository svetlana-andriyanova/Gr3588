
int[] testarr = GenArray(10, -100, 100);
Print1DArr(testarr);
int[] result = ConvertArr(testarr);
Print1DArr(result);


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


int[] ConvertArr(int[] arr)
{
    int[] outArr = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        outArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return outArr;
}