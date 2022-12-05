//Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Создаем переменную
int number = numberSintezator.Next(100, 1000);

Console.WriteLine(number);

// int firstNumber=number/100;
// int secondNumber= number%10;

// int result=firstNumber*10+secondNumber;
// Console.WriteLine(result);

int result=(number/100)*10+number%10;
Console.WriteLine(result);