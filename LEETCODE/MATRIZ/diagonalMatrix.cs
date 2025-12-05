class Solution
{
    public int[,] toFillMatrix()
    {
        int[,] matrix = new int[5, 5];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    matrix[i, j] = 1;
                }
                else
                {
                    matrix[i, j] = 0;
                }
            }
        }

        return matrix;
    }

    public static void Main(string[] args)
    {
        var sol = new Solution();
        int[,] result = sol.toFillMatrix();

        // pra printar a matriz no console tem que percorrer e usar Console.Write para cada elemento

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}