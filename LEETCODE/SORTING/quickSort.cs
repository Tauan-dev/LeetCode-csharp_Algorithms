public class Solution
{
    public int[] SortArray(int[] nums, int left, int right)
    {
        if (left < right)// a função só funciona enquanto o ponteiro da esquerda for menor da direita
        {
            int pivo = Partition(nums, left, right); // chama a função Partition que vai retornar o primeiro pivo (que vai dividir dividir o array em 2, para que sejam ordenados posteriormente de forma recursiva)
            SortArray(nums, left, pivo - 1); // pega o subvetor da esquerda(com os valores menor que o pivo)
            SortArray(nums, pivo + 1, right); // pega os subvetor da direita, com os valores maiores
        }
    }

    public int Partition(int[] array, int left, int right)
    {
        int pivo = array[right];// vai pegar o ultimo valor do array como pivo
        int i = left - 1; // valor "fantasma" que esta antes da primeira posição no array, essa posição vai ser utilizado para percorrer o vetor depois

        for (int j = left; j < right; j++) //j = left é a primeira posição do array, e rigth a ultima, então j vai ser utilizado para percorrer
        {
            if (array[j] < pivo) // caso a posição de j dentro do vetor for menor que o pivo [esse caso é para ordenar em ordem crescente, sem repetição de valores]
            {
                i++; // o indice i é incrementado
                (array[i], array[j]) = (array[j], array[i]); // j e i trocam de posição
            }
        }

        (array[i + 1], array[right]) = (array[right], array[i + 1]);
        return i + 1; // vai retornar a posição do pivo
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 5, 3, 8, 4, 2 };
        solution.SortArray(nums, 0, nums.Length - 1); // chama o método de ordenação com o vetor e os índices inicial e final
        Console.WriteLine(string.Join(", ", nums));
    }
}