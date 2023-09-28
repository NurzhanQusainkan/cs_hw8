//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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



    static void SortRowsDescending(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            // Создаем временный массив для сортировки текущей строки
            int[] tempArray = new int[numCols];

            // Копируем текущую строку во временный массив
            for (int j = 0; j < numCols; j++)
            {
                tempArray[j] = array[i, j];
            }

            // Сортируем временный массив по убыванию
            Array.Sort(tempArray, (a, b) => b.CompareTo(a));

            // Копируем отсортированные значения обратно в исходную строку
            for (int j = 0; j < numCols; j++)
            {
                array[i, j] = tempArray[j];
            }
        }
    }

int rows = SetNumber("- количество строк");
int columns = SetNumber("- количество столбцов");


int[,] result = GetMatrix(rows, columns);
PrintMatrix(result);
SortRowsDescending(result);
Console.WriteLine();
PrintMatrix(result);