//Программа, возвращает сумму цифр в числе. Рекурсия

int number = ReadData("Введите число M ");
int result = RecSumDigit(number);
PrintData("Сумма чисел равна: "+result);

int RecSumDigit(int num)
{
    if (num < 10) return num;
    return num % 10 + RecSumDigit(num / 10);
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
