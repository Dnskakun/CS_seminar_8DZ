// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


//Console.Clear();

int rows = 6;
int columns = 8;

int[,] array = FillArray(rows, columns);
PrintArray(array);


// Функции, используемые в программе

int[,] FillArray(int row, int column)
{
    int[,] outArray = new int[row, column];
    int count = 1;
        
    for (int j = 0; j < column; j++)
    {
        outArray[0, j] = count;
        count += 1;
    }
    int currentPositionRow = 1;
    int currentPositionColumn = column - 1;
    int tmp = 0;

    for (int step = 1; step < row; step++)
    {
        for (int i = 0; i < row - step; i++)
        {
           if (outArray[currentPositionRow + i, currentPositionColumn] == 0)
           {
           outArray[currentPositionRow + i, currentPositionColumn] = count;
           count += 1;
           tmp = currentPositionRow + i;
           }
           else break;
        }
        currentPositionRow = tmp;
        currentPositionColumn = column - step - 1;
        for (int j = 0; j < column - step; j++)
        {
            if (outArray[currentPositionRow, currentPositionColumn - j] == 0)
            {
            outArray[currentPositionRow, currentPositionColumn - j] = count;
            count += 1;
            tmp = currentPositionColumn - j;
            }
            else break;            
        }
        currentPositionColumn = tmp;
        currentPositionRow = currentPositionRow - 1;
        for (int m = 0; m < row - step - 1; m++)
        {
            if (outArray[currentPositionRow - m, currentPositionColumn] == 0)
            {
                outArray[currentPositionRow - m, currentPositionColumn] = count;
                count += 1;
                tmp = currentPositionRow - m;
            }
            else break;
        }
        currentPositionRow = tmp;
        currentPositionColumn = currentPositionColumn + 1;
        for (int n = 0; n < column - step - 1; n++)
        {
            if (outArray[currentPositionRow, currentPositionColumn + n] == 0)
            {
            outArray[currentPositionRow, currentPositionColumn + n] = count;
            count += 1;
            tmp = currentPositionColumn + n;
            }
            else break;
        }
        currentPositionColumn = tmp;
        currentPositionRow = currentPositionRow + 1;
    }
    return outArray;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < 10) Console.Write($"0{inArray[i, j]}  ");
            else Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}




