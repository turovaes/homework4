
int ReadNumber(string message)
{
    Console.Write(message);
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Ошибка, введите число");
    }
    return number;
}

int SumNumber(int num)
{
    int sum = 0;
   
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }

    
    return sum;
}

int num = ReadNumber("Введите число для подсчета суммы его цифр ");
int answer = SumNumber(num);
Console.WriteLine($"Сумма цифр числа {num} = {answer}");