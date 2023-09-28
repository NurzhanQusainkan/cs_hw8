//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] GetMatrix(int rows, int columns, int min = 0, int max = 9)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.BackgroundColor = ConsoleColor.Black;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) Console.ForegroundColor = ConsoleColor.Green;
            else Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

static int FindRowWithMinSum(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        int minSum = int.MaxValue; 
        int minSumRowIndex = 0;

        for (int i = 0; i < numRows; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < numCols; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
    }


int rows = SetNumber("- количество строк");
int columns = SetNumber("- количество столбцов");


int[,] result = GetMatrix(rows, columns);
int rowIndex = FindRowWithMinSum(result);

PrintMatrix(result);
Console.WriteLine($"Строка с наименьшей суммой элементов: {rowIndex}");