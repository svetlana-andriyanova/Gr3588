﻿
// Считываем данные с консоли

int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");


int result = num2 % num1;

if (result = 0)
{
    Console.WriteLine(" Число делется без остатка");
}
else
    Console.WriteLine("Число не делится без остатка. Остаток " + result);
