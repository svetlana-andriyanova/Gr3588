int number = ReadData("Введите число");
PrintData("Результат " + DecToBin(number));

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

// string DecToBin(int num)
// {
//     string outBin = String.Empty;
//     while (num > 0)
//     {
//         outBin = (num % 2) + outBin;
//         num = num / 2;
//     }
//     return outBin;

// }

string DecToBin(int num)
{

    return Convert.ToString(num, 2);

}

