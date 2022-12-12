// Программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] coordA = ReadData("Введите координаты точки А: X Y Z");
int[] coordB = ReadData("Введите координаты точки В: X Y Z");

PrintData("Расстояние между точками равна: ", ColculateDistance(coordA[0], coordA[1], coordA[2], coordB[0], coordB[1], coordB[2]));

// Метод читает данные от пользователя
int[] ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine()!.Split(' ').Select(x => int.Parse(x)).ToArray(); // Разбивает строку, разделенных пробелом, в массив и парсит 
}

// Метод рассчитывает расстояние между точками
double ColculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return res;
}

// Метод вывода в консоль
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}



// int coordX1 = ReadData("Введите координату Х1");
// int coordY1 = ReadData("Введите координату Y1");
// int coordZ1 = ReadData("Введите координату Z1");
// int coordX2 = ReadData("Введите координату Х2");
// int coordY2 = ReadData("Введите координату Y2");
// int coordZ2 = ReadData("Введите координату Z2");

// PrintData("Длина между точками равна: ", ColculateLength(coordX1, coordY1, coordZ1, coordX2, coordY2, coordZ2));

// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Метод рассчитывает расстояние между точками
// double ColculateLength(double x1,double y1, double z1, double x2,double y2, double z2)
// {
//     // Решение
//     double res = 0;
//     res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) +Math.Pow((z1 - z2), 2));
//     return res;
// }
// // Метод вывода в консоль
// void PrintData(string msg, double res)
// {
//     Console.WriteLine(msg + res);
// }
