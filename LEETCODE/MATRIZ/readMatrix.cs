class Solution
{
    public int Contador(int[,] matrix)
    {
        int counter = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > 10) // corrigido de matrix[i][j] para matrix[i, j] 
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    public static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4]
        {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        Solution solution = new Solution(); // instância a classe Solution
        int resultado = solution.Contador(matriz);
        Console.WriteLine(resultado);
    }
}