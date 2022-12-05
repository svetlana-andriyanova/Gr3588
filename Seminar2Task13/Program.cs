// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int num1 = int.Parse(Console.ReadLine() ?? "0");   //Персим число и проверяем его на пустое значение

// Вариант 1
double numberOfDigits = Math.Floor(Math.Log10(num1) + 1);  // Определяем количесвто цифр в числе

if (numberOfDigits >= 3)  // Проверяем трехзначное ли число
{
    while (numberOfDigits != 3)   // Если число 4, 5...- значное, то отсекаем последнюю циру
    {
        num1 = num1 / 10;
        numberOfDigits = numberOfDigits - 1;
    }

    int result = num1 % 10;  // Определяем остаток от деления
    Console.WriteLine(result);   // Выводим в консоль
}
else

    Console.WriteLine("Третьей цифры нет");

// Вариант 2
// if (num1>99)
// {
//     char[] digit=num1.ToString().ToCharArray();
//     Console.WriteLine(digit[2]);
// }
// else
// Console.WriteLine("Третьей цифры нет");


