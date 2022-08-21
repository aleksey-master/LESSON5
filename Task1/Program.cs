// Задайте массив заполненный случайными положительными трёхзначными
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//создание массива
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}
//вывод массива на консоль
void PrintArray(int[] array)
{
    for (int j=0; j < array.Length; j++)
    {
        System.Console.Write(array[j]+"\t");
    }
    System.Console.WriteLine();
}
//нахождение положительных чисел в произвольном массиве
int QuantityPositiveNumbers(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}
int[] array =CreateArray(4, 100, 1000);
PrintArray(array);
System.Console.WriteLine();
int quantity = QuantityPositiveNumbers(array);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");