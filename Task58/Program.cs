// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return res;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] arrey1 = GetArray(7, 7, 0, 10);
PrintArray(arrey1);
Console.WriteLine();
int[,] arrey2 = GetArray(7, 7, 0, 10);
PrintArray(arrey2);
Console.WriteLine();

int [,] MatrixMult (int [,] arr1, int [,] arr2)
{
    int [,] mult = new int [arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(0); j++)
        {
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
                mult [i,k] = arr1[i,j] * arr2[j,k];
            }
        }
    }
    return mult;
}

int [,] multResult = MatrixMult (arrey1, arrey2);
PrintArray (multResult);