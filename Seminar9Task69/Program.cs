//Программа, возвразает число А в степени В. Рекурсия

int numberA = ReadData("Введите число A ");
int numberB = ReadData("Введите число B ");
long result = MyPow(numberA, numberB);
PrintData( result);

long MyPow(int A, int B)
{
    if (B==2) return A * A;
    if(B==1)return A;
    if (B%2==0)
    {
        return MyPow(A, B/2) * MyPow(A, B/2);
    }
    else
    return MyPow(A, B/2) * MyPow(A, B/2+1);
}

long RecPow(int A, int B)
{
    if (B <= 1) return A;
    return A * RecPow(A, B - 1);
}
// Метод вывода данных
void PrintData(long msg)
{
    Console.WriteLine(msg);
}

// Метод считывания данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
