class Solution
{
    public double[,] generateMatrix()
    {
        double[,] matrix = new double[10, 10];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i < j)
                {
                    matrix[i, j] = 2 * i + 7 * j - 2;
                }
                else if (i == j)
                {
                    matrix[i, j] = 3 * Math.Pow(i, 2) - 1;
                }
                else
                {
                    matrix[i, j] = 4 * Math.Pow(i, 2) - 5 * Math.Pow(j, 2) + 1;
                }
            }
        }

        return matrix;
    }

    public static void Main(string[] args)
    {
        var solution = new Solution();
        double[,] result = solution.generateMatrix();

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}