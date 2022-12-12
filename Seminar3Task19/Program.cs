//Программа которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int number = ReadData("Введите пятизначное число: "); // Получаем данные с консоли используя метод ReadData
double numberOfDigits = Math.Floor(Math.Log10(number) + 1); //Определяем количетсво цифр в числе

if (numberOfDigits == 5) // Проверяем на пятизначность
{
    bool result = PalinTest(number); // Проверяем на палиндром, используя метод PalinTest
    if (result)
    {
        PrintData(number, " Это палиндром"); // Выводим результат в консоль с помощью метода PrintData
    }
    else
    {
        PrintData(number, " Это не палиндром");
    }

}
else
    Console.WriteLine("Это не пятизначное число");


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных в консоль
void PrintData(int num, string msg)
{
    Console.WriteLine(num + msg);
}

// Метод определения на палиндром
bool PalinTest(int num)
{
    bool result = false;
    result = (num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10);
    return result;
}






// Решение с использованием словаря

// int number = ReadData("Введите пятизначное число: "); // Получаем данные с консоли используя метод ReadData

// if (number >= 10000 && number <= 99999) // Проверяем на пятизначность
// {
//     Dictionary<int, int> palindrom = new Dictionary<int, int>();
//     palindrom = DictionaryFill();
//     bool result = PalinTest(number, palindrom); // Проверяем на палиндром, используя метод PalinTest
//     if (result)
//     {
//         PrintData(number, " Это палиндром"); // Выводим результат в консоль с помощью метода PrintData
//     }
//     else
//     {
//         PrintData(number, " Это не палиндром"); // Проверка на пятизначность
//     }
// }
// else
// Console.WriteLine("Это не пятизначное число"); 

// // Метод заполнения словаря
// Dictionary<int, int> DictionaryFill()
// {
//     Dictionary<int, int> dict = new Dictionary<int, int>();
//     int keyNum = 1;
//     for (int secondNum = 0; secondNum <= 9; secondNum++)
//     {
//         for (int firstNum = 1; firstNum <= 9; firstNum++)
//         {
//             dict[keyNum] = firstNum * 1000 + secondNum * 100 + secondNum * 10 + firstNum;
//             keyNum++;
//         }
//     }
//     return dict;
// }

// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Метод вывода данных в консоль
// void PrintData(int num, string msg)
// {
//     Console.WriteLine(num + msg);
// }

// // Метод определения на палиндром
// bool PalinTest(int num, Dictionary<int, int> palindrom)
// {
//     bool result = false;
//     if (palindrom.ContainsValue((number/1000)*100+number%100))
//     {
//         result = true;
//     }
//     return result;
    
// }

