using System;
class Solution
{
    public double Desvio(int[] nums)
    {
        int sum = 0;
        double DpSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        double media = sum / (double)nums.Length; // a media é o tamanho do array, e não 2, presta atenção

        for (int j = 0; j < nums.Length; j++)
        {
            DpSum += Math.Pow(nums[j] - media, 2);
        }

        double result = Math.Sqrt(DpSum / (nums.Length - 1.0));

        return result;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 1, 2, 3, 4, 5, 10, 31 };
        double result = solution.Desvio(nums);
        Console.WriteLine(result);
    }
}