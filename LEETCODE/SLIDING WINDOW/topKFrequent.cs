public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int i = 0;
        int[] result = new int[k];
        Dictionary<int, int> counter = new(); // instância a função Dictionary <Tkey,Tvalue>
        counter[nums[0]] = 1; // o primeiro valor que aparece no array recebe um valor 

        while (i < nums.Length - 1) // percorre o vetor !NESSE CASO TEM QUE SRE COM WHILE, COM O FOR INCIANDO EM 0, ELE VAI PERCORRER COUNTER[NUMS[0]] NOVAMENTE
        {
            i++;// tem que incrementar o i para percorrer 
            if (counter.ContainsKey(nums[i])) //caso no dicionário tenha aquela chave
            {
                counter[nums[i]]++; // ele incrementa um valor dentro daquela chave 
            }
            else
            {
                counter[nums[i]] = 1; // caso nao, ele inicia uma nova chave e da valor de 1 a ela(ou seja uma ocorrência)
            }
        }

        if (counter != null)
        {
            for (int j = 0; j < k; j++) // tinha utilizado result[i] = counter.Value().Max() - i;, que nao funciona com o LINQ. i tinha sido declarado globalmente, então gerava erro
            {
                // dicionarios são pares de dados então
                int maxFreq = 0;
                int maxKey = 0;

                foreach (var pair in counter) // para cada par dentro do dicionário
                {
                    if (pair.Value > maxFreq) // caso o valor do par for maior que a frequencia 
                    {
                        maxFreq = pair.Value; // a maior frenquencia recebe esse valor
                        maxKey = pair.Key; // e o key guarda a chave relacionada(ou seja o numero que é repetido)
                    }
                }

                result[j] = maxKey; // guarda a chave dentro do vetor de resultado
                counter.Remove(maxKey); // remove a chave do dicionário e repete a operação enquanto tiver valores de k
            }
        }

        return result;
    }


}