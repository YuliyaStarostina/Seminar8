// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.Clear();
System.Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вы ввели размерность массива {m} x {n}");
Console.WriteLine($"Исходный массив:");

int[,] arrayrandom = new int[m, n];
Random rnd = new Random();
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10, 60);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j], 5} ");
        }
        System.Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
            if (array[i, k+1] < array[i, k])
            {
                temp = array[i, k+1];
                array[i, k+1]= array[i, k];
                array[i, k] = temp;
            }
            }
        }
    }
}
FillArray(arrayrandom);
PrintArray(arrayrandom);
SortArray(arrayrandom);
System.Console.WriteLine($"Массив, отсортированный по строкам:");
PrintArray(arrayrandom);