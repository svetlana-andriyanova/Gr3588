//Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = ReadData("Введите число ");

DateTime d1 = DateTime.Now;
int sum = SumDigit(number);
TimeSpan firstMethod = DateTime.Now - d1;

DateTime d2 = DateTime.Now;
int sumLine = SumDigitsLine(number);
TimeSpan secondMethod = DateTime.Now - d2;

PrintData("Сумма чисел равна (методом целочисленного деления) ", sum);
PrintData("Сумма чисел равна (методом преобразования в строку) ", sumLine);
Perform(firstMethod,secondMethod);

// Метод определения скорости расчета
void Perform(TimeSpan firstNum, TimeSpan secondNum)
{
    if (firstNum < secondNum)
    {
        Console.WriteLine("Расчет методом целочисленного деления быстрее, чем методом преобразования в строку ");
    }
    else Console.WriteLine("Расчет метод преобразования в строку быстрее, чем метод целочисленного деления ");
}

// Запрос данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int numP = int.Parse(Console.ReadLine() ?? "0");
    return numP;
}

// Метод вывода данных
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

// Метод расчет суммы чисел через целочисленное деление
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }

    return res;
}

// Расчет суммы чисел через строку
int SumDigitsLine(int num)
{
    string str = num.ToString();
    int[] digits = new int[str.Length];
    int sum = 0;
    for (int i = 0; i < str.Length; i++)
    {
        digits[i] = int.Parse(str[i].ToString());
        sum += digits[i];
    }

    return sum;
}

