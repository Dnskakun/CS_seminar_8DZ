// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] array = FillArray(3, 3, 3, 10, 100);
PrintArray(array);


//Функции, ипользуемые в программе

int[,,] FillArray(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] outArray = new int[rows, columns, depth];
    var rnd = new Random();
    for (int m = 0; m < depth; m++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int number = rnd.Next(minValue, maxValue);
                if (ContainsRepeat(outArray, number))
                {
                    j--;
                    continue;
                }
                else outArray[i, j, m] = number;
            }
        }
    }
    return outArray;
    
    bool ContainsRepeat(int[,,] inArray, int checkNumber)
    {
        for (int m = 0; m < depth; m++)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (inArray[i, j, m] == checkNumber) return true;
                }
            }
        }
        return false;
    }
}

void PrintArray(int[,,] inArray)
{
    for (int m = 0; m < inArray.GetLength(2); m++)
    {
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
            for (int j = 0; j < inArray.GetLength(0); j++)
            {
                Console.Write($"{inArray[i, j, m]} ({i},{j},{m})  ");
            }
            Console.WriteLine();
        }
    }
}




