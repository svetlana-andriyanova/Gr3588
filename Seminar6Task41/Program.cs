//Пользователь вводит число нажатий, затем программа выдает количество положительных чисел.

using System.Text.RegularExpressions;

int numPress = ReadData("Введите количество нажатий ");

PrintData("Введите символы");
string inputLine = ReadPress(numPress);
PrintData("Исходная строка символов " + inputLine);

PrintData("Количество положительных чисел равно " + CountPosNum(inputLine));

//Метод считывает нажатия пользователя и записывает в строку
string ReadPress(int num)
{
       string line = string.Empty;
    for (int i = 0; i < num; i++)
    {
        var key = Console.ReadKey(true);
        line = line + String.Format(key.KeyChar.ToString());
    }
    return line;
}

// Метод подсчета количества положительных чисел
int CountPosNum(string line)
{
    int[] digits = Regex.Matches(line, @"(-?\d+)").OfType<Match>().Select(m => int.Parse(m.Value)).ToArray(); // Выбираем числа из строки и записываем в массив
    int count = 0;
    for (int i = 0; i < digits.Length; i++)
        if (digits[i] > 0)
            count++;
    return count;
}

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных в консоль
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
