// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.WriteLine("Hello, World!");
Console.Write("Введите длинну массива = ");
int length = Convert.ToInt32(Console.ReadLine());
int[] CreateRandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 999);
    }
    return array;
}
int AmountEvenNumber(int[] array)
{
    int amounteven = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
        {
            amounteven++;
        }

    }
    return amounteven;
}

void PrintArray(int[] array)
{
    Console.Write("В представленном массиве - [");
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}
int[] array = CreateRandomArray(length);
int amountEvenNumber = AmountEvenNumber(array);
PrintArray(array);
Console.WriteLine($" Количество четных элементов = {amountEvenNumber}");