//Программа, который принимает на вход пример и решает его. 

using System.Text.RegularExpressions;

string Text = ReadData("Введите операцию в формате х+у \nДоступные арифметические операции: + - * / ^ ");
double example = Calculate(Text);
PrintData("= ", example);

//Метод, который разбивает пример на числа и операции и решает его
double Calculate(string str)
{
    int numA, numB;
    Match mat = Regex.Match(str, @"(\-*[\d,]+)([\*\/\-\+\^]{1})(\-*[\d,]+)"); // Находит в строке совпадение число-оператор-число
    {
        numA = int.Parse(mat.Groups[1].ToString()); 
        numB = int.Parse(mat.Groups[3].ToString());
        double result = 1;
        if (mat.Groups[2].ToString()[0] == '*')
            result = Multiply(numA, numB); // Вызов метода умножения
        else if (mat.Groups[2].ToString()[0] == '/')
            result = Div(numA, numB); // Вызов метода деления
        else if (mat.Groups[2].ToString()[0] == '+')
            result = Sum(numA, numB); // Вызов метода сложения
        else if (mat.Groups[2].ToString()[0] == '-')
            result = Sub(numA, numB); // Вызов метода вычитания
        else if (mat.Groups[2].ToString()[0] == '^')
            result = Pow(numA, numB); // Вызов метода возведения в степень
        return result;
    }

}

// Метод читает данные от пользователя
string ReadData(string msg)
{
    Console.WriteLine(msg);
    string numLine = Console.ReadLine() ?? "0";
    return numLine;
}

// Метод вывода в консоль
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

//Метод возведения в степень
double Pow(int firstNum, int secondNum)
{
    double result = 1;
    result = Math.Pow(firstNum, secondNum);
    return result;
}

//Метод сложения
double Sum(int firstNum, int secondNum)
{
    double result = 1;
    result = firstNum + secondNum;
    return result;
}

//Метод вычитания
double Sub(int firstNum, int secondNum)
{
    double result = 1;
    result = firstNum - secondNum;
    return result;
}

//Метод деления
double Div(int firstNum, int secondNum)
{
    double result = 1;
    result = firstNum / secondNum;
    return result;
}

//Метод умножения
double Multiply(int firstNum, int secondNum)
{
    double result = 1;
    result = firstNum * secondNum;
    return result;
}




// // Метод возведения в степень через цикл
// double Pow(int firstNum, int secondNum)
// {
//     double result = 1;
//     for (int i = 1; i <= secondNum; i++)
//     {
//         result = firstNum * result;
//     }
//     return result;
// }

// string example = ReadData("Введите операцию ");
// int numB = ReadData(" Введите число B ");

// double res = Pow(numA, numB);

// PrintData("А в степени В равно: ", res);





