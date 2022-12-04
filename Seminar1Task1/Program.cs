string? Num1line = Console.ReadLine();
string? Num2line = Console.ReadLine();

if (Num1line != null && Num2line != null)
{
    int num1 = int.Parse(Num1line);
    int num2 = int.Parse(Num2line);

    bool outResult = num1 * num1 == num2;
    Console.WriteLine(outResult);
}
