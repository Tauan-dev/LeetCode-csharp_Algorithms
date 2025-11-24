public class Solution
{
    public int HIndex(int[] citations)
    {
        int index = 0;
        QuickSort(citations, 0.citations.Length - 1);

        for (int i = citatiosn.Length - 1; i >= 0; i--) // a forma mais simples de se pensar aqui é percorrer o array de tras pra frente 
        {
            if (citations[i] > index)
            {
                index++;
            }
        }

        return index;
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

    public int Partition(int[] vetor, int left, int rigth)
    {
        int pivo = array[rigth];
        int i = left - 1;

        for (int j = left; j < rigth; j++)
        {
            if (vetor[j] < pivo)
            {
                i++;
                (vetor[i], vetor[j]) = (vetor[j], vetor[i]);
            }
        }

        (vetor[i + 1], vetor[rigth]) = (vetor[rigth], vetor[i + 1]);
        return i + 1;
    }
}