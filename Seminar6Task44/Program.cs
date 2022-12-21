int number = ReadData("Введите число");
PrintData("Результат " + FibNum(number));


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных в консоль
void PrintData(string res)
{
    Console.WriteLine(res);
}

string FibNum(int num)
{
    string outLine = "0 1 ";
    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 2; i < num; i++)
    {
        outLine = outLine + (first + last).ToString() + " ";
        buf = first;
        first = last;
        last = last + buf;
    }
    return outLine;
}
