// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

bool IsQ(string letter)
{
    if (letter == "q") return true;
    else return false;
}

bool IsEven(int num)
{
    if (num % 2 == 0) return true;
    else return false;
}

int CountElementsSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Введите целое число или q");
while (true)
{
    int num = 0;
    string input = Console.ReadLine();
    if (int.TryParse(input,out num))
    {
        if (IsEven(CountElementsSum(num))) break;
        else Console.WriteLine("Введите следующее число");
    }
    else if (IsQ(input)) break;
    else Console.WriteLine("Введен некорректный символ. Введите q, либо целое число");
}