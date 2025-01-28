using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter rows for the matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter columns for the matrix: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix1 = CreateRandomMatrix(rows, cols);
        int[,] matrix2 = CreateRandomMatrix(rows, cols);

        Console.WriteLine("Matrix 1:");
        DisplayMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        DisplayMatrix(matrix2);

        Console.WriteLine("Addition of Matrices:");
        DisplayMatrix(AddMatrices(matrix1, matrix2));

        Console.WriteLine("Subtraction of Matrices:");
        DisplayMatrix(SubtractMatrices(matrix1, matrix2));

        if (cols == matrix1.GetLength(0))
        {
            Console.WriteLine("Multiplication of Matrices:");
            DisplayMatrix(MultiplyMatrices(matrix1, matrix2));
        }

        Console.WriteLine("Transpose of Matrix 1:");
        DisplayMatrix(TransposeMatrix(matrix1));

        if (rows == 2 && cols == 2)
        {
            Console.WriteLine($"Determinant of Matrix 1: {Determinant2x2(matrix1)}");
            Console.WriteLine("Inverse of Matrix 1:");
            DisplayMatrix(Inverse2x2(matrix1));
        }

        if (rows == 3 && cols == 3)
        {
            Console.WriteLine($"Determinant of Matrix 1: {Determinant3x3(matrix1)}");
            Console.WriteLine("Inverse of Matrix 1:");
            DisplayMatrix(Inverse3x3(matrix1));
        }
    }

    static int[,] CreateRandomMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }
        return matrix;
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix2.GetLength(1);
        int common = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < common; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transpose = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }
        return transpose;
    }

    static int Determinant2x2(int[,] matrix)
    {
        return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
    }

    static int Determinant3x3(int[,] matrix)
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
             - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
             + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    static double[,] Inverse2x2(int[,] matrix)
    {
        double determinant = Determinant2x2(matrix);
        if (determinant == 0) return null;
        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1] / determinant;
        inverse[0, 1] = -matrix[0, 1] / determinant;
        inverse[1, 0] = -matrix[1, 0] / determinant;
        inverse[1, 1] = matrix[0, 0] / determinant;
        return inverse;
    }

    static double[,] Inverse3x3(int[,] matrix)
    {
        double determinant = Determinant3x3(matrix);
        if (determinant == 0) return null;
        double[,] inverse = new double[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int[,] minor = new int[2, 2];
                int r = 0, c = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (x == i) continue;
                    c = 0;
                    for (int y = 0; y < 3; y++)
                    {
                        if (y == j) continue;
                        minor[r, c++] = matrix[x, y];
                    }
                    r++;
                }
                inverse[j, i] = (Determinant2x2(minor) * (int)Math.Pow(-1, i + j)) / determinant;
            }
        }
        return inverse;
    }

    static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    static void DisplayMatrix(double[,] matrix)
    {
        if (matrix == null)
        {
            Console.WriteLine("Matrix is not invertible.");
            return;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]:F2}\t");
            }
            Console.WriteLine();
        }
    }
}
