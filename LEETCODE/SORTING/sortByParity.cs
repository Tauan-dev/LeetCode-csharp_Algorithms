// Problema: Mover Pares para o Início
//
// Dado um vetor de números inteiros 'nums', mova todos os números pares
// para o início do vetor, seguidos por todos os números ímpares.
//
// Retorne qualquer array que satisfaça esta condição.
//
// Observação: A ordem relativa dos pares entre si e dos ímpares entre si
// não precisa ser preservada.

public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {

        if (nums.Length > 1)
        {
            PartitionPair(nums, 0, nums.Length);

        }
        return nums;
    }


    public void PartitionPair(int[] array, int left, int rigth)
    {
        int i = left - 1;

        for (int j = left; j < rigth; j++)
        {
            if (array[j] % 2 == 0)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 3, 1, 2, 4 };
        int[] sortedArray = solution.SortArrayByParity(nums);

        Console.WriteLine("Array ordenado por paridade: " + string.Join(", ", sortedArray));
    }
}