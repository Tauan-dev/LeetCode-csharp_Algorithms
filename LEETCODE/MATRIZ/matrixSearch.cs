public class Solution
{
    // quando a matrix é declarada como int[][], é chamada como jagged array, então não é acessado com GetLength(0) e sim com Length e matrix[i].Length para o j. Ou seja, GetLength é utilizado para arrays multidimensionais, como int[,]
    public bool SearchMatrix(int[][] matrix, int target)
    {
        bool result = false;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == target)
                {
                    result = true;

                }

            }
        }

        return result;
    }


    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        bool result = sol.SearchMatrix(new int[][] {
            new int[] {1, 2, 5, 7},
            new int[] {10, 11, 16, 20},
            new int[] {23, 30, 34, 60}
        }, 3);
    }
}