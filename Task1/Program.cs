
int ReadNumber(string message)
{
    Console.Write(message);
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.WriteLine("It's not an int");
    }
    return n;
}

int Exponentiate(int numberA, int numberB)
{
    int result = (int)Math.Pow(numberA, numberB);
    return result;
}

int numberA = ReadNumber("Number A = ");
int numberB = ReadNumber("Number B = ");
int answer = Exponentiate(numberA, numberB);

Console.WriteLine($"Число А в степени В = {answer}");
