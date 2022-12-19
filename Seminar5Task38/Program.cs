// Программа выполняет сортировку методом вставки, подсчета и пузырьковым методом, выводит время выполнения сортировки. 
// Определяет разницу между максимальным и минимальным элементом массива.

int[] testarr = GenArray(10, 1, 100); 
PrintData("Сгенерированный массив ");
Print1DArr(testarr);

// Определяем время выполнения сортировки каждым способом
DateTime d1 = DateTime.Now; 
int[] arrInsertSort = InsertSort(testarr);
Console.WriteLine("Время выполнения сортировки методом вставки: ");
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int[] arrCountSort = CountSort(testarr);
Console.WriteLine("Время выполнения сортировки методом подсчета: ");
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
int[] arrBubbleSort = BubbleSort(testarr);
Console.WriteLine("Время выполнения сортировки пузырьковым методом: ");
Console.WriteLine(DateTime.Now - d3);

// Вывод отсортированного массива разными методами в консоль
PrintData("Массив, отсортирован методом вставки");
Print1DArr(arrInsertSort);
PrintData("Массив, отсортирован методом подсчета");
Print1DArr(arrCountSort);
PrintData("Массив, отсортирован методом пузырька");
Print1DArr(arrBubbleSort);

int difference = DiffMaxMin(arrBubbleSort); 
PrintData("Разница между максимальным и минимальным элементом массива равна: " + difference);

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

// Метод вывода данных
void PrintData(string res)
{
    Console.WriteLine(res);

}

// Сортировка методом вставки
int[] InsertSort(int[] array)
{
    for (int i = 1; i < array.Length; i++) // Последовательно сравнивает и меняет элементы местами при необходимости
    {
        int max = array[i];
        int j = i;
        while (j > 1 && array[j - 1] > max)
        {
            int temp = array[j];
            array[j] = array[j - 1];
            array[j - 1] = temp;
            j -= 1;
        }
        array[j] = max;
    }
    return array;
}

// Сортировка методом подсчета
int[] CountSort(int[] array)
{
    int maxValue = array[array.Length - 1]; 
    int[] count = new int[maxValue + 1]; // Вспомогательный массив
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i]]++;
    }
    int index = 0;
    for (int i = 0; i < count.Length; i++) // Сортирует исходный массив в соответсвии со вспомогательным
    {
        for (int j = 0; j < count[i]; j++)
        {
            array[index] = i;
            index++;
        }

    }
    return array;
}

//Сортировка пузырьковым методом
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

// Метод определения разницы между максимальным и минимальным элементом массива
int DiffMaxMin(int [] array)
{
    int res = array[array.Length - 1] - array[0];
    return res;
}