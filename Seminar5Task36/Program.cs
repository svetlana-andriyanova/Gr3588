// Программа считает сумму чисел, которые находятся на нечетных местах и находит пары одинаковых элменетов и их индексы.
int[] testarr = GenArray(10, 1, 10);
PrintData("Сгенерированный массив");
Print1DArr(testarr);

int result = SumOdd(testarr);
PrintData("Сумма элементов на нечетных местах равна: " + result);

PrintData("Пары одинаковых элементов массива находятся на местах:");
Dubble(testarr);

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

// Метод вывода одномерного массива
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

// Метод определения суммы чисел на нечетных позициях
int SumOdd(int[] arr)
{
    int res = 0;
    int i = 1;
    while (i < arr.Length)
    {
        res += arr[i];
        i = i + 2;
    }
    return res;
}

//Метод ищет пары элементов и выдет индексы этих элементов
void Dubble(int[] arr)
{
    int firstIndex = 0;
    int secondIndex = 0;
    for (int i = 0; i < arr.Length; i++)
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[i] == arr[j])
            {
                firstIndex = i;
                secondIndex = j;
                Console.WriteLine(arr[i] + " = " + firstIndex + "," + secondIndex);
                arr[j] = arr[j] * (-1);
                break;
            }
}

