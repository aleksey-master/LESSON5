/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных 
позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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
    for (int j=0; j < array.Length; j++)
    {
        System.Console.Write(array[j]+"\t");
    }    System.Console.WriteLine();
}


int[] array = CreateArray(12, -9, 9);
PrintArray(array);