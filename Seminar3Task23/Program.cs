int numN = ReadData("Введите число");

string outLine = LineBuilder(numN, 1);

PrintData(" ", outLine);
outLine = LineBuilder(numN, 3);
PrintData(" ", outLine);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}

string LineBuilder(int digits, int pow)
{
    string line = string.Empty;
    for (int i = 1; i < digits; i++)
    {
        line += Math.Pow(i, pow) + " ";
    }
    line += Math.Pow(digits, pow);
    return line;
}

