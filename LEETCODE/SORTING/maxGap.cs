public class Solution
{
    public int MaximumGap(int[] nums)
    {

        int maxGap = 0;
        QuickSort(nums, 0, nums.Length - 1);

        if (nums.Length > 1)
        {
            for (int i = 0; i < nums.Length - 1; i++) // o erro estava aqui, faltava o -1
            {

                int gap = nums[i + 1] - nums[i];
                if (gap > maxGap)
                {
                    maxGap = gap;
                }

            }
        }
        else
        {
            return maxGap;
        }


        return maxGap;
    }

    public void QuickSort(int[] number, int left, int rigth)
    {
        if (left < rigth)
        {
            int pivo = Partition(number, left, rigth);
            QuickSort(number, left, pivo - 1);
            QuickSort(number, pivo + 1, rigth);
        }
    }

    public int Partition(int[] array, int left, int rigth)
    {
        int pivo = array[rigth];
        int i = left - 1;

        for (int j = left; j < rigth; j++)
        {
            if (array[j] < pivo)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        (array[i + 1], array[rigth]) = (array[rigth], array[i + 1]);
        return i + 1;
    }

    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int result = sol.MaximumGap(new int[] { 3, 6, 9, 1, 15 });
        Console.WriteLine(result);
    }
}