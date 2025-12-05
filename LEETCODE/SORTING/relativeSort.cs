public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        int aux = 0;
        int left = 0;
        int k = left - 1;

        // As vezes é necessário olhar a forma mais simples de resolver o problema antes de partir para algo mais complexo.

        // Olhe para esse caso, onde o array 2 já esta ordenado na forma que queremos, não precisava criar um dicionário para contar as ocorrências.

        // Dictionary<int, int> nums = new Dictionary<int, int>();
        // nums[arr2[0]] = 1;
        // while (i < arr2.Length - 1)
        // {
        //     if (nums.ContainsKey(nums[i]))
        //     {
        //         nums[arr2[i]]++;
        //     }
        //     else
        //     {
        //         nums[arr2[i]] = 1;
        //     }
        //     i++;
        // }

        while (aux < arr2.Length)
        {
            for (int j = 0; j < arr1.Length; j++)
            {

                if (arr1[j] == arr2[aux])
                {
                    k++; // assim que terminar o laço em relação aos valores que contém no array 2, k vai ser a ultima posição, ou seja a primeira posição do vetor que sobra é k+1, que é a continuação do que temos 
                    (arr1[j], arr1[k]) = (arr1[k], arr1[j]);
                }

            }
            aux++;
        }

        int tailNew = k + 1;
        if (tailNew < arr1.Length)
        {
            QuickSort(arr1, tailNew, arr1.Length - 1);
        }

        return arr1;
    }

    public void QuickSort(int[] nums, int left, int rigth)
    {
        if (left < rigth)
        {
            int pivot = Partition(nums, left, rigth);
            QuickSort(nums, left, pivot - 1);
            QuickSort(nums, pivot + 1, rigth);
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
        int[] arr1 = { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19, 18, 17, 40 };
        int[] arr2 = { 2, 1, 4, 3, 9, 6 };

        int[] sortedArray = solution.RelativeSortArray(arr1, arr2);

        Console.WriteLine("Array ordenado: " + string.Join(", ", sortedArray));
    }

}