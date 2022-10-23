// Показать двумерный массив размером m×n заполненный вещественными числами


void FillArray(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            double number = new Random().NextDouble();
            int a = new Random().Next(-9, 10);
            matr[m, n] = Math.Round(number * a, 2); ;
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
double[,] matrix = new double[5, 3];
FillArray(matrix);
Console.WriteLine($"Двумерный массив размером [{matrix.GetLength(0)}x{matrix.GetLength(1)}]: ");
PrintArray(matrix);
