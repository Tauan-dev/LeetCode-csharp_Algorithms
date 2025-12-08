public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        int counter = 1;
        int longest = 1;

        QuickSort(nums, 0, nums.Length - 1);

        for (int i = 1; i < nums.Length - 1; i++) // o laço percorre o vetor fazendo a verificação de uma primeira sequencia de numeros
        {
            if (nums[i] == nums[i - 1])
            {
                continue; // utilizado para ignorar possiveis duplicatas 
            }

            else if (nums[i] == nums[i - 1] + 1)
            {
                counter++; // caso o valor atual seja exatamente a sequencia do anterior o contador é aumentado 
            }
            else
            {
                if (counter > longest)
                {
                    longest = counter;
                    counter = 1;
                }
            }

        }

        if (counter > longest) // faz uma nova comparação com o counter 
        {
            longest = counter;
        }

        return longest;
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
            if (nums[j] <= pivo)
            {
                i++;
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
        }

        (nums[i + 1], nums[rigth]) = (nums[rigth], nums[i + 1]);
        return i + 1;
    }
}