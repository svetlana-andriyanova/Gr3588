//Программа, которая выдает все натуральные числа в промежутке до N. Рекурсия

int number = ReadData("Введите число N ");
string result = LineGenRec(number);
PrintData(result);

string LineGenRec(int num)
{
    if (num <= 0)
    {
        return string.Empty;
    }
    else
    {
        string outLine = num + " " + LineGenRec(num - 1);
        return outLine;
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
