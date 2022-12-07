int qut = ReadData("Введите номер четверти");
PrintAnswer(qut);
// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintAnswer(int number)
{
    // Решение
    if (number > 0 && number < 5)
    {
        if (number == 1) Console.WriteLine("Точка в четверти x > 0; y > 0");
        if (number == 2) Console.WriteLine("Точка в четверти x > 0; y < 0");
        if (number == 3) Console.WriteLine("Точка в четверти x < 0; y < 0");
        if (number == 4) Console.WriteLine("Точка в четверти x > 0; y < 0");
    }
    else Console.WriteLine("Вы ввели не номер четверти");
}