{
    int positivSum = 0;
    int negativSum = 0;

    int[] testarr = GenArray(12, -9, 9);
    NegativPositivSum(testarr);
    Print1DArr(testarr);
    PrintData("Сумма положительных чисел в массиве: ", positivSum);
    PrintData("Сумма отрицательных чисел в массиве: ", negativSum);

    // Метод вывода данных
    void PrintData(string msg, int value)
    {
        Console.WriteLine(msg + value);
    }

    // Метод определения победителя рандомно
    int[] GenArray(int len, int minValue, int maxValue)
    {
        Random rnd = new Random();
        int[] arr = new int[len];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(minValue, maxValue+1);

        }
        return arr;
    }

    void NegativPositivSum(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                positivSum += arr[i];
            }
            else
            {
                negativSum += arr[i];
            }
        }
    }
    void Print1DArr(int[] arr)
    {
        for (int i=0; i<arr.Length-1; i++)
        {
            Console.Write(arr[i]+ ", ");
        }
        Console.WriteLine(arr[arr.Length-1]);
    }
}