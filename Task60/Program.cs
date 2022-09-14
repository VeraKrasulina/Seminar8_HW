// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Get3DArray(int l, int m, int n, int minValue, int maxValue)
{
    int[,,] res = new int[l, m, n];
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n; k++)
            {
                res[i, j, k] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return res;
}

void Print3DArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write(inArray[i, j, k] + " (" + i + "," + j + "," + k + ")" + "\t");
            }
        }
        Console.WriteLine();
    }
}

int [,,] array = Get3DArray (2,2,2,1,10);
Print3DArray (array);