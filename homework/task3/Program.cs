// Напишите программу, которая перевернёт 
// одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateRandomArray(int lowBound, int highBound, int size)
{

    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(lowBound, highBound + 1);
    }
    return array;

}

int[] ReverseArray(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;

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

Console.WriteLine("Введите минимальное число в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(min, max, size);
ShowArray(array);
Console.WriteLine();
ShowArray(ReverseArray(array));