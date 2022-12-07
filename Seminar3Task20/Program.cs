int coordX1 = ReadData("Введите координату Х1");
int coordY1 = ReadData("Введите координату Y1");
int coordX2 = ReadData("Введите координату Х2");
int coordY2 = ReadData("Введите координату Y2");

PrintData("Длина между точками равна: ", ColculateLength(coordX1, coordY1, coordX2, coordY2));

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double ColculateLength(double x1,double y1,double x2,double y2)
{
    // Решение
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return res;
}

void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
