// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
//например, 1 строка
Console.Clear();
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений: ");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] GetArray(int n, int m, int max)
{
    int[,] Array = new int[n, m];
    var rnd = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = rnd.Next(1, max);
        }
    }
    return Array;
}
void PrintArray(int[,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"|");
            Console.Write($"{Array[i, j],3}" + "\t");
        }
        Console.WriteLine();
    }
}
double[] SumArrayRown(int[,] array)
{
    double sum = 0;
    double[] SumArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        SumArray[j] = sum;
        sum = 0;
    }
    return SumArray;
}
void SumRownPrint(double[] Array)
{
    double min = double.MinValue;
    int n = 0;

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (min < Array[i])
        {
            min = Array[i];
            n = i;
        }
    }
    Console.WriteLine($"{n} строка");
}
int[,] result = GetArray(n, m, max);
PrintArray(result);
Console.WriteLine();
double[] result1 = SumArrayRown(result);
SumRownPrint(result1);