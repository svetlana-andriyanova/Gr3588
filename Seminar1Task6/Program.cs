// Программа, которая на вход принимает число и выдаёт, является ли число чётным

// Считываем данные с консоли
string? Numline = Console.ReadLine();

// Проверяем, что данные не пустые
if (Numline != null)
{
    // Персим число
    int num = int.Parse(Numline);

    // Проверяем четное ли число
    int outResult = num % 2;

    if (outResult == 0)
    {
        Console.WriteLine(" Число чётное "); // Выводим данные в консоль
    }
    else
        Console.WriteLine(" Число нечетное ");
}
