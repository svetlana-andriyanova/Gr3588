
// Считываем данные с консоли

int num1 = int.Parse(Console.ReadLine()??"0");



int result1=num1%7;
int result2=num1%23;

if (result1==0 && result2==0)
{
    Console.WriteLine("Да");
}
else
Console.WriteLine("Нет");
