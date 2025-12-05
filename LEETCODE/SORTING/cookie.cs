public class Solution
{
    // Ao ler o enunciado, o pedido é maximizar a quantidade de filhos satisfeitos, ou seja se o tamanho do biscoito for  >= a fome do filho, aquele biscoito é dado ao filho. para isso é interessante ordenar os vetores, por que ao percorrer, os valores vão crescer, então os biscoitos serão direcionados. nosso ponto de limite é ou a quantidade de biscoitos, ou se todos os filhos estão satisfeitos 
    public int FindContentChildren(int[] g, int[] s)
    {
        QuickSort(g, 0, g.Length - 1);
        QuickSort(s, 0, s.Length - 1);
        int i = 0;
        int j = 0;
        int counter = 0;

        // ao utilizar uma matriz , gera uma erro no qual o mesmo biscoito é contado mais de uma vez, e o else encerra a função na primeira vez que um biscoito for menor que a criança atual
        // a abordagem correta é utilizar two pointers onde i percorre g (crianças) e j percorre s (biscoitos)

        //errado

        // for (int i = 0; i < g.Length; i++)
        // {
        //     for (int j = 0; j < s.Length; j++)
        //     {
        //         if (g[i] <= s[j])
        //         {
        //             counter++;
        //         }
        //         else
        //         {
        //             return counter;
        //         }
        //     }
        // }

        while (i < g.Length && j < s.Length)
        {
            if (s[j] >= g[i])
            {
                counter++;
                i++;
                j++;
            }
            else
            {
                j++; // se o cookie for muito pequeno, tenta o próximo 
            }
        }


        return counter;
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

    public int Partition(int[] vetor, int left, int rigth)
    {
        int pivo = vetor[rigth];
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

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] g = { 1, 2, 3 };
        int[] s = { 1, 1 };
        int result = solution.FindContentChildren(g, s);
        Console.WriteLine(result);
    }
}