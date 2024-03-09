// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int lowBound, int highBound, int size) // если необходимо, чтобы функция вернула массив, то тип тоже должен быть массив
{

    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(lowBound, highBound + 1);
    }
    return array;

}

bool IsThreeDigit(int num)
{
    if (num >= 100 && num <= 999) return true;
    else return false;
}

int CountOfEven(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

void PrintArray(int [] array)
{
    foreach(int e in array)
    {
        Console.Write($"{e} ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введите минимальное число в массиве из трехзначных чисел: ");

while (true)
{
   int min = Convert.ToInt32(Console.ReadLine());
    if (IsThreeDigit(min))
    {
        Console.WriteLine("Введите максимальное число в массиве: ");
        int max = Convert.ToInt32(Console.ReadLine());
        if (IsThreeDigit(max))
        {
            Console.WriteLine("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = CreateRandomArray(min, max, size);
            PrintArray(array);
            Console.WriteLine("Количество четных чисел в массиве равно " + CountOfEven(array));
            break;
        }
        else
        {
            Console.WriteLine("Число должно быть трехзначным");
        }

    }
    else
    {
        Console.WriteLine("Число должно быть трехзначным");
    }
}
