// Запрос данных от пользователя
using System.Numerics;

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


BigInteger CalcFactor(int num)
{

    BigInteger result=1;
    for (int i=1; i<=num; i++ )
    {
        result*=i;
    }
    return result;
    
}

int num = ReadData("Введите X ");
BigInteger factorial= CalcFactor(num);
PrintResult("Факториал от X " + factorial);
