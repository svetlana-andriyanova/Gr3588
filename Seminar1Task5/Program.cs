string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int starNumber = inputNumber * (-1);
    string outLine = string.Empty;

    while (starNumber < inputNumber)
    {
        outLine = outLine + starNumber + ", ";
        starNumber++;
    }

    outLine = outLine + inputNumber;
    Console.WriteLine(outLine);
}


