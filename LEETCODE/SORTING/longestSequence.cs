public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        

        return nums;
    }

    public void QuickSort(int[] array, int left, int rigth)
    {
        if (left < rigth)
        {
            int pivo = Partition(array, left, rigth);
            QuickSort(array, left, pivo - 1);
            QuickSort(array, pivo + 1, rigth);
        }
    }

    public int Partition(int[] nums, int left, int rigth)
    {
        int pivo = nums[rigth];
        int i = left - 1;
        int count = 0;

        for (int j = left; j < rigth; j++)
        {
            if (nums[j] < pivo)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        (array[i + 1], array[rigth]) = (array[rigth], array[i + 1]);
        return i + 1;
    }
}