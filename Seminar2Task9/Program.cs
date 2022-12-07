//Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Создаем переменную
int number = numberSintezator.Next(10, 100);

//Console.WriteLine(number);

//Получаем первое и второе число по отдельности
int firstNumber = number / 10;
int secondNumber = number % 10;

//Сравниваем числа

// if (firstNumber > secondNumber)
// {
//     Console.WriteLine(firstNumber);
// }
// else
// {
//     Console.WriteLine(secondNumber);
// }

//Вариант 2
char[] digit=numberSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digit);
firstNumber = ((int)digit[0]) -48;
secondNumber = ((int)digit[1]) -48;

int resultNumber=firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

Console.WriteLine(resultNumber);

