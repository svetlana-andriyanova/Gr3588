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

int CountSimple(int num)
{
    int res = 0;
    while (num > 0)
    {
        res++;
        num = num / 10;

    }

    return res;
}

int CountString(int num)
{
    int count = num.ToString().Length;
    return count;
}


int num = ReadData("Введите число ");

DateTime d1 = DateTime.Now;
int lenght = CountSimple(num);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int lenghtString = CountString(num);
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
int reslog = (int)Math.Log10(num) + 1;
Console.WriteLine(DateTime.Now - d3);

PrintResult("Количество чисел по легкому варианту " + lenght);
PrintResult("Количество чисел через строку " + lenghtString);
PrintResult("Количество чисел через логарифм " + reslog);
