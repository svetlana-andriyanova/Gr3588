
int[] testarr = GenArray(20, 1, 100);
Print1DArr(testarr);
int digit = ReadData("Введите число: ");
int result = SearchElement(testarr, digit);
if (result >= 0)
{
    PrintData("Элемент найден в позиции: " + result);

}
else
    PrintData("В массиве элемент не найден");

// Метод определения победителя рандомно
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


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0"); ;
}

// Метод вывода данных
void PrintData(string res)
{
    Console.WriteLine(res);

}

int SearchElement(int[] arr, int element)
{
    int res = -1;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == element)
        {
            res = i;
            break;
        }
    }

    return res;
}