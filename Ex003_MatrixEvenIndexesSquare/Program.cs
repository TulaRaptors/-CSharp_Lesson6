// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillMatrix(int[,] matrix, int minimum, int maximum)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(minimum, maximum);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

void ChangeEvenElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
                matrix[i, j] = matrix[i, j] * matrix[i, j]; //Math.Pow(matrix[i,j],2);
}


Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[rows, columns];
FillMatrix(matrix, 1, 10);
Console.WriteLine("Ваша матрица: ");
PrintMatrix(matrix);
ChangeEvenElements(matrix);
Console.WriteLine("Обновленная матрица: ");
PrintMatrix(matrix);