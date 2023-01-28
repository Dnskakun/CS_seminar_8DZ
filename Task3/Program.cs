// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.Clear();

int[,] array1 = FillArray(4, 3, 0, 10);
int[,] array2 = FillArray(3, 4, 0, 10);
PrintArray(array1);
PrintArray(array2);
int[,] resultArrays = ProductOfMatrix(array1, array2);

if (resultArrays == null) Console.WriteLine();
else PrintArray(resultArrays);


//Функции, используемые в программе
int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return newArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProductOfMatrix(int[,] inArray1, int[,] inArray2)
{
    if (inArray1.GetLength(1) == inArray2.GetLength(0))
    {
        int[,] productArray = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
        for (int i = 0; i < inArray1.GetLength(0); i++)
        {
            for (int j = 0; j < inArray2.GetLength(1); j++)
            {
                int tmpSum = 0;
                for (int r = 0; r < inArray1.GetLength(1); r++)
                {
                    tmpSum += inArray1[i, r] * inArray2[r, j];
                }
                productArray[i, j] = tmpSum;
            }
        }
        return productArray;
    }
    else
    {
        Console.WriteLine("Произведения данных матриц не существует.");
        return null;
    }
}



