// Программа, определяющая случайного победителя

string[] arrName = ReadData("Введите имена через запятую ");
string name = GenArray(arrName);
PrintData("Победитель: ", name);

// Метод считывания данных пользователя
string[] ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine()!.Split(',').ToArray(); // Разбивает строку, разделенных запятой
}

// Метод вывода данных
void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}

// Метод определения победителя рандомно
string GenArray(string[] arr)
{
    int rnd = new Random().Next(0, arr.Length);
    return arr[rnd];
}
