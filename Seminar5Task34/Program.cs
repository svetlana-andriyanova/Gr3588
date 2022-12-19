// Программа задает массив, состоящий из случайных положительных трехзначных чисел и показывает количество чётных чисел.
// Сортирует массив методом пузырька

int[] testarr = GenArray(100, 100, 999);
PrintData("Сгенерированный массив");
PrintArray(testarr);

int result = CountEven(testarr);
PrintData("Количество четных элементов в массиве: " + result);

int[] sortArr = BubbleSort(testarr);
PrintData("Массив отсортированный методом пузырька: ");
PrintArray(sortArr);

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

// Метод вывода данных
void PrintData(string res)
{
    Console.WriteLine(res);

}

// Метод подсчета четных чисел в массиве 
int CountEven(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}

// Сортировка пузырьковым методом
int[] BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
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

