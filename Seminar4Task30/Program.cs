
int arrLen=ReadData("Введите длину массива ");
int [] arr =GenArray(arrLen);
PrintData("Сгенерированный массив:", arr);


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return  int.Parse(Console.ReadLine() ?? "0");;
}

// Метод вывода данных
void PrintData(string res, int [] arr)
{
    Console.WriteLine(res);
    PrintArray(arr);
}


int[] GenArray(int num)
{
    Random rnd=new Random ();
    int[] arr = new int[num];
    for (int i = 0; i< arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void PrintArray( int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length-1;i++)
{
    Console.Write(arr[i]+", ");

}
 Console.Write(arr[arr.Length-1]+"]");
}
