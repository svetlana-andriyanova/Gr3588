// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

// Проверяем, что данные не пустые
if (inputLine != null)
{
    // Персим число
    int inputNumber = int.Parse(inputLine);

    int startNumber = 2; // Первое четное число
    string outLine = string.Empty; // Обозначаем переменную с пустой строкой

    while (startNumber < inputNumber)
    {
        // Проверяем на четность последнее число
        if (inputNumber % 2 == 0)
        {
            outLine = outLine + startNumber + ", "; // Записываем в outLine четные числа через запятую
            startNumber = startNumber + 2; // 2, 4, 6 ....
        }
        else
            inputNumber = inputNumber - 1; 

    }

    outLine = outLine + inputNumber; // Добавляем последнее четное число
    Console.WriteLine(outLine); // Выводим данные в консоль
}