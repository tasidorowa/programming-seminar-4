// using System.Runtime.ExceptionServices;

int[] CreateRandomArray(int lowBound, int highBound, int size) // если необходимо, чтобы функция вернула массив, то тип тоже должен быть массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(lowBound, highBound + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int CountOfPrimes(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (IsPrime(item)) count++;
    }
    return count;
}

bool IsPrime(int num)
{
    double limit = Math.Sqrt(num);
    for (int i = 2; i <= limit; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}

int CountDeftoSeven(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (IsDefToSeven(item)) count++;
    }
    return count;
}

bool IsDefToSeven(int num)
{
    if (num % 7 == 0 && num % 10 == 1) return true;
    else return false;
}

// Задача 1. Задайте одномерный массив, заполненный случайными числами, опеределите кол-во простых числе в массиве

Console.WriteLine("Введите минимальное число в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(min, max, size);
ShowArray(array);
// int count = CountOfPrimes(array);
// Console.WriteLine($"Количество простых чисел в массиве равно {count}");

// Задача 2. Задать массив из N целых случайных чисел и найти кол-во чисел, которые заканчиваются на 1 и делятся на 7.

int count = CountDeftoSeven(array);
Console.WriteLine($"Количество числе, оканчивающихся на 1 и делящихся на 7 без остатка равно {count}");