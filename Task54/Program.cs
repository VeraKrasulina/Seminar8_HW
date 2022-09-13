// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void BubbleSort(int[] arr1)
{
    int temp;
    for (int i = 0; i < arr1.Length - 1; i++)
    {
        for (int j = i + 1; j < arr1.Length; j++)
        {
            if (arr1[i] < arr1[j])
            {
                temp = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = temp;
            }
        }
    }
}

void SortingArreyByRows(int[,] arr2)
{
    int[] arr3 = new int[arr2.GetLength(0)];
    int j = 0;
    while (j < arr2.GetLength(1))
    {
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            arr3[i] = arr2[j, i];
        }
        BubbleSort(arr3);
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            arr2[j, i] = arr3[i];
        }
        j++;
    }
}

int[,] arrey = GetArray(7, 7, 0, 10);
PrintArray(arrey);
Console.WriteLine();
SortingArreyByRows(arrey);
PrintArray(arrey);
