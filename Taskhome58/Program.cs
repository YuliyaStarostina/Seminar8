//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// по умолчанию размер столбцов первой матрицы равен размеру строк второй матрицы

System.Console.WriteLine("Задайте количество строк первой матрицы: ");
int firstrow = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Задайте количество столбцов первой матрицы: ");
int firstcolumn = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Задайте количество строк второй матрицы: ");
int secondrow = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Задайте количество столбцов второй матрицы: ");
int secondcolumn = int.Parse(Console.ReadLine()!);
int[,] firstArray = new int[firstrow, firstcolumn];
CreateArray(firstArray);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstArray);

int[,] secondArray = new int[secondrow, secondcolumn];
CreateArray(secondArray);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secondArray);

int[,] resultArray = new int[firstcolumn, secondrow];
MultiplyArray(firstArray, secondArray, resultArray);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultArray);

void MultiplyArray(int[,] firstArray, int[,] secomdArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
    {
        sum += firstArray[i, k] * secomdArray[k, j];
    }
    resultArray[i, j] = sum;
}
  }

}
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 51);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


