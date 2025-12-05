class Solution
{
    public int diagonalSum(int[,] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                if (i == j)
                {
                    sum += nums[i, j];
                }
            }
        }

        return sum;
    }

    public static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3] { { 4, 6, 1 }, { 12, 1, 7 }, { 2, 0, 5 } };
        var solution = new Solution();
        int result = solution.diagonalSum(matrix);

        Console.WriteLine(result);

    }
}