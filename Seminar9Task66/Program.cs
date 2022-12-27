//ПрограммА находит сумму натуральных элементов в промежутке от M до N. Рекурсия

int numM = ReadData("Введите число M ");
int numN = ReadData("Введите число N ");
int result = SumMN(numM, numN);
PrintData("Сумма элменетов равна: "+result);

//Метод поиска суммы чисел от M до N
int SumMN(int M, int N)
{
    if (M>=N ) 
    {
        return N;
    }
    else
    {
              return M+SumMN(M+1,N);
    }
}

// Метод вывода данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод считывания данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
