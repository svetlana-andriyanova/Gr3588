Console.WriteLine("Введите день недели: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if ((number > 0) && (number < 8))
{
    Dictionary<int, string> dict = new Dictionary<int, string>
    {
        {1, "рабочий день"},
        {2, "рабочий день"},
        {3, "рабочий день"},
        {4, "рабочий день"},
        {5, "рабочий день"},
        {6, "выходной день"},
        {7, "выходной день"},
    };
    Console.WriteLine(dict[number]);
}
else
Console.WriteLine("Вы ввели не день недели");