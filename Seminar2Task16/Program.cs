
// Считываем данные с консоли

void Test(int i, int j)
{
    bool result = (i / j == j);
    if (result==true) Console.WriteLine(i + " квадрат " + j);
    else Console.WriteLine(i + " не квадрат " + j);
}


int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");

// bool result1 = (num1 / num2 == num2);
// bool result2 = (num2 / num1 == num1);

// if (result1) Console.WriteLine(num1 + " квадрат " + num2);
// if (result2) Console.WriteLine(num1 + " не квадрат " + num2);
// if (!result1&&!result2) Console.WriteLine(" Ни первое, ни второе число не является квадратом ");


Test(num1, num2);
Test(num2, num1);