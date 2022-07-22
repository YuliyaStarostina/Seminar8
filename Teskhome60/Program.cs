//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int n = 4, m = 4, k = 4, max = 10;
int[,,] GetArray(int n, int m, int k, int max)
{
    int[,,] Array = new int[n, m, k];
    var rnd = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int b = 0; b < Array.GetLength(2); b++)
            {
                Array[i, j, b] = rnd.Next(1, max);
            }
        }
    }
    return Array;
}
void PrintArray(int[,,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int b = 0; b < Array.GetLength(2); b++)
            {

                Console.Write($"{Array[i, j, b],3} ({i},{j},{b})");
            }
            Console.WriteLine();
        }
    }
}
int[,,] result = GetArray(n, m, k, max);
PrintArray(result);
Console.WriteLine();



