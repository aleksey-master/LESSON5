/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных
позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

//создание массива случайных чисел
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

//вывод массива на консоль
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

//поиск суммы элементов, в массиве случайных чисел, стоящих на нечетных позициях
int RandomNumbers(int numberPosition, int min, int max)
{
    int[] randomNumbers = new int[numberPosition];
    int sumElements = 0;
    Console.Write("Массив случайных чисел: ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 1)
        {
            sumElements = sumElements + randomNumbers[i];
        }
    }
    return sumElements;
}

int randomNumbers = RandomNumbers(4, 1, 10);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");
