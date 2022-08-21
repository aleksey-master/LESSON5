// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7.3 22.2 2 78] -> 76

//Задание массива вещественных чисел.
System.Console.Write("Массив вещественных чисел: ");
double[] array = new double[4];
Random rand = new Random();
Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((rand.NextDouble() * 100), 1);
    System.Console.Write(array[i] + "; ");
}
Console.Write("]");

//Поиск разницы между максимальным и минимальным элементами массива
double maxNumber = array[0];
double minNumber = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
    }
    if (minNumber > array[i])
    {
        minNumber = array[i];
    }
}
double difference = Math.Round((maxNumber - minNumber), 1);
Console.WriteLine(
    $"\nРазница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {maxNumber} - {minNumber} = {difference}"
);
