public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        int[] aux = nums;
        QuickSort(nums, 0, nums.Length - 1);
        int j = nums.Length - 1;
        int i = 0;


        //O erro está no laço abaixo, não é pra ser feito dessa forma

        // while (sum != target)
        // {
        //     sum = nums[i] + nums[j];
        // }

        // if (sum < target)
        // {
        //     i++;
        // }
        // else if (sum > target)
        // {
        //     j--;
        // }

        while (i < j)
        {
            int sum = aux[i] + aux[j];
            if (sum == target)
            {
                break;
            }
            if (sum < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        // caso você coloque nums[i], você vai trazer o valor e não a posição, que é o pedido pno two sum
        result[0] = i;
        result[1] = j;

        return result;

    }

    public void QuickSort(int[] vetor, int left, int rigth)
    {
        if (left < rigth)
        {
            int pivo = Partition(vetor, left, rigth);
            QuickSort(vetor, left, pivo - 1);
            QuickSort(vetor, pivo + 1, rigth);

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
        Solution solution = new Solution();
        int[] nums = { 3, 2, 4 };
        int target = 6;
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
    }

}