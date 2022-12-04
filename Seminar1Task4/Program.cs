// Программа принимает на вход три числа и выдаёт максимальное из этих чисел.

// Считываем данные с консоли
string? Num1line = Console.ReadLine();
string? Num2line = Console.ReadLine();
string? Num3line = Console.ReadLine();

// Проверяем, что данные не пустые
if (Num1line != null && Num2line != null && Num3line != null)
{
    // Парсим введенные числа
    int num1 = int.Parse(Num1line);
    int num2 = int.Parse(Num2line);
    int num3 = int.Parse(Num3line);

    if (num1 > num2) // Сравниваем первое число со вторым
    {
        if (num1 > num3) // Сравниваем первое число с третьем
        {
            Console.WriteLine("max = " + num1); // Выводим данные в консоль
        }
        else
            Console.WriteLine("max = " + num3);
    }
    else
        if (num2 > num3) // Сравниваем второе число с третьем
    {
        Console.WriteLine("max = " + num2);
    }
    else
        Console.WriteLine("max = " + num3);

}