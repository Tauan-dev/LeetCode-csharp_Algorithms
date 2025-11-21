public class Solution
{
    public int[] QuickSort(int[] vetor, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(vetor, left, right);
            QuickSort(vetor, left, pivot - 1);
            QuickSort(vetor, pivot + 1, right);
        }
        return vetor;
    }

    public int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++) // lembre que é < right
        {
            if (array[j] <= pivot) // para ordenar em ordem crescente, com repetição de valores
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        (array[i + 1], array[right]) = (array[right], array[i + 1]);
        return i + 1;
    }

    public int FindKthLargest(int[] nums, int k)
    {

        if (nums.Length == 1)
        {
            return nums[0];
        }

        QuickSort(nums, 0, nums.Length - 1);
        return nums[nums.Length - k];

    }
}