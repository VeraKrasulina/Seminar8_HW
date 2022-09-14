// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] RowToOneDimentionalMassive(int[,] arr, int rowNumber)
{
    int[] arr1 = new int[arr.GetLength(1)];
        int k =0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            arr1[i] = arr[rowNumber, i];
        }

    return arr1;
}

int SummArrayValues(int[] arr2)
{
    int summ = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        summ += (int)arr2[i];
    }
    return summ;
}

int[] GettingArrayOfRowSums(int[,] inArray)
{
    int[] arr4 = new int[inArray.GetLength(0)];
    int[] arrayOfSums = new int[inArray.GetLength(1)];
    
    for (int countYIndex = 0; countYIndex < inArray.GetLength(1); countYIndex++)
    {
        arr4 = RowToOneDimentionalMassive(inArray, countYIndex);
        arrayOfSums[countYIndex] = SummArrayValues(arr4);
    }
    return arrayOfSums;
}

int ArrayMininumValue(int[] arr3)
{
    int min = arr3[0];
    int minInd = 0;
for (int i = 0; i < arr3.Length; i++)
{
    int value = arr3[i];
    if(min > value)
    {
        minInd = i;
        min = value;
    }
}
    return minInd;
}

int[,] arrey = GetArray(7, 7, 0, 10);
PrintArray(arrey);
Console.WriteLine();
int [] summs = GettingArrayOfRowSums(arrey);
int result = ArrayMininumValue(summs);
Console.WriteLine($"Строка с наименьшей суммой - {result}.");



