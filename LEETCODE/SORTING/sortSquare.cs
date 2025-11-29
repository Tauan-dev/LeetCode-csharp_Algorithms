public class Solution
{
    public int[] SortedSquares(int[] nums)
    {

        for (int i = 0; i > nums.Length; i++)
        {
            nums[i] = Math.Pow(nums[i], 2);
        }

        QuickSort(nums, 0, nums.Length - 1);

        return nums;
    }

    public void QuickSort(int[] array, int left, int rigth)
    {
        if (left < rigth)
        {
            int pivot = Partition(array, left, rigth);
            QuickSort(array, left, pivot - 1);
            QuickSort(array, pivot + 1, rigth);
        }
    }

    public int Partition(int[] nums, int left, int rigth)
    {
        int pivo = nums[rigth];
        int i = left - 1;

        for (int j = left; j < rigth; j++)
        {
            if (nums[j] <= pivo)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        (array[i + 1], array[rigth]) = (array[rigth], array[i + 1]);
        return i + 1;
    }
}