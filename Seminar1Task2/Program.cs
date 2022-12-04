// Программа на вход принимает два числа и выдаёт максимальное

// Считываем данные с консоли
string? Num1line = Console.ReadLine();
string? Num2line = Console.ReadLine();

// Проверяем, что данные не пустые
if (Num1line != null && Num2line != null)
{
    // Парсим введенные числа
    int num1 = int.Parse(Num1line);
    int num2 = int.Parse(Num2line);

    // Определяем максимальное
    int maxNum = Math.Max(num1, num2);

    // Выводим данные в консоль
    Console.WriteLine("max = " + maxNum);
}