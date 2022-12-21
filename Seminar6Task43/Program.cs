// Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.
// Программа ищет площадь треугольника образованного пересечением 3 прямых.

double b1 = ReadData("Введите b1 ");
double k1 = ReadData("Введите k1 ");
double b2 = ReadData("Введите b2 ");
double k2 = ReadData("Введите k2 ");
double b3 = ReadData("Введите b3 ");
double k3 = ReadData("Введите k3 ");

(double x, double y) pointA = CrossPoint(b1, k1, b2, k2);
(double x, double y) pointB = CrossPoint(b3, k3, b2, k2);
(double x, double y) pointC = CrossPoint(b1, k1, b3, k3);

PrintData("Координаты первой точки: x1= " + pointA.x +" y1= "+ pointA.y);
PrintData("Координаты первой точки: x1= " + pointB.x +" y1= "+ pointB.y);
PrintData("Координаты первой точки: x1= " + pointC.x +" y1= "+ pointC.y);

double square = SquareTriangle(pointA.x, pointA.y, pointB.x, pointB.y, pointC.x, pointC.y);
PrintData("Площадь треугольника равна: " + square);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных в консоль
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод определения точек пересечения 
(double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * b2 - k2 * b1) / (k1 - k2);
    return (x, y);
}

// Метод определения площади треугольника по координатам вершин
double SquareTriangle(double x1, double y1, double x2, double y2, double x3, double y3)
{
    double square = 0.5 * ((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3));
    return square;
}

