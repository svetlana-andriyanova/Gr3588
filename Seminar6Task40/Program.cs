
int cutA=ReadData("Введите отрезок А");
int cutB=ReadData("Введите отрезок B");
int cutC=ReadData("Введите отрезок C");

if (TriangleTest(cutA, cutB, cutC)) PrintData("Треугольник с такими сторонами может существовать");
else PrintData("Треугольник с такими сторонами не сущетсвует");


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных в консоль
void PrintData( string msg)
{
    Console.WriteLine(msg);
}

bool TriangleTest(int a, int b, int c)
{
    return ((a + b > c) && (a + c > b) && (b + c > a));
}
