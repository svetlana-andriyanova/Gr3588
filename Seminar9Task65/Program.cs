//Программа, которая выдает все натуральные числа в промежутке от M до N. Рекурсия

int numberM = ReadData("Введите число M ");
int numberN = ReadData("Введите число N ");
string result = numberM < numberN ? RecMN(numberM, numberN) : RecMN(numberN, numberM);
PrintData(result);

string RecMN(int m, int n)
{
    string outLine = string.Empty;
    if (m >= n) return outLine + n;
    outLine = m + " " + RecMN(m + 1, n);
    return outLine;
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
