// Программа вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int numM = ReadData("Введите число M ");
int numN = ReadData("Введите число N ");
int result = AkkermanF(numM, numN);
PrintData($"Функция Аккермана для чисел ({numM},{numN}) = "+result);

// Функция Аккермана
int AkkermanF(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AkkermanF(m - 1, 1);
    else
      return AkkermanF(m - 1, AkkermanF(m, n - 1));
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
