// Задача 54: Задайте двумерный массив. Напишите программу,\
// которая упорядочит по убыванию элементы каждой строки
// двумерного массива.

Console.Clear();

int[,] array = FillArray(4, 4, 0, 10);
PrintArray(array);
SortArrayRowsFromLargerToSmall(array);
PrintArray(array);

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

void SortArrayRowsFromLargerToSmall(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) - 1; j++)
        {
            int maxNumber = inArray[i, j + 1];
            int maxNumberColumnIndex = j + 1;
            for (int m = j + 1; m < inArray.GetLength(1); m++)
            {
                if (inArray[i, m] > maxNumber)
                {
                    maxNumber = inArray[i, m];
                    maxNumberColumnIndex = m;
                }
            }
            if (inArray[i, j] < maxNumber)
            {
                int tmp = inArray[i, j];
                inArray[i, j] = maxNumber;
                inArray[i, maxNumberColumnIndex] = tmp;
            }
        }
    }
}



