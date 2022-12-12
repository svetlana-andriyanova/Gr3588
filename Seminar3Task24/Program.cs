// Запрос данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int numP = int.Parse(Console.ReadLine() ?? "0");
    return numP;
}

// Метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int SumSimple(int numA)
{
    int sumOfNum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNum += i;
    }
    return sumOfNum;
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
int res1 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Сумма числа от 1 до A равна: " + res1);
PrintResult("Сумма числа от 1 до A равна: " + res2);

int SumGauss(int numA)
{
    int sumOfNum = 0;
    sumOfNum = ((1 + numA) * numA) / 2;
    return sumOfNum;
}






