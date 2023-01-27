// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

Console.Clear();

int[,] array = FillArray(3, 4, 0, 10);
PrintArray(array);
FindStringMinSumInArray(array);



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

void FindStringMinSumInArray(int[,] inArray)
{
    int minSum = 0;
    int minSumIndexRow = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        if (i == 0)
        {
            minSum = sum;
            minSumIndexRow = i;
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumIndexRow = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumIndexRow + 1}.");
}





