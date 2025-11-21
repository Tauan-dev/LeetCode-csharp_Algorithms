// Problema: Sort Colors (Dutch National Flag Problem)
//
// Dado um array 'nums' com n objetos coloridos de vermelho, branco ou azul,
// ordene-os no próprio array de forma que os objetos da mesma cor fiquem adjacentes,
// com as cores na ordem: vermelho, branco e azul.
//
// Representação das cores:
// - 0 = vermelho
// - 1 = branco
// - 2 = azul
//
// Restrição: resolver SEM usar a função de ordenação da biblioteca.
//
// Exemplo 1:
// Entrada: nums = [2, 0, 2, 1, 1, 0]
// Saída:   [0, 0, 1, 1, 2, 2]
//
// Exemplo 2:
// Entrada: nums = [2, 0, 1]
// Saída:   [0, 1, 2]


class Solution
{
    public void QuickSort(int[] color, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(color, left, right);
            QuickSort(color, left, pivot - 1);
            QuickSort(color, pivot + 1, right);
        }
    }

    public int Partition(int[] array, int left, int right)
    {
        int pivo = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++) // o j tem que ser começado em left, que é a primeira posição do array, caso não resulte em erro, como eu estava fazendo antes (int j=0);
        {
            if (array[j] <= pivo)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        (array[i + 1], array[right]) = (array[right], array[i + 1]);
        return i + 1;
    }

    public static void Main()
    {
        int[] colors = new int[] { 2, 0, 2, 1, 1, 0 };
        Solution solution = new Solution();
        solution.QuickSort(colors, 0, colors.Length - 1);

        foreach (var color in colors)
        {
            Console.Write(color + " ");
        }
    }
}
