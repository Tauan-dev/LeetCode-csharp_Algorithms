
// O algoritmo de kadane é um padrão bem útil sempre que você quer o melhor seguimento contínuo de algo
// exemplos :       
// Maior subarray de soma máxima (achar o melhor intervalo de lucro/prejuízo),(achar o período com maior temperatuda acumulada, maior consumo de energia, etc)

//Máxima variação/lucro
// detectar intervalo com maior ganho de usuários, vendas, etc

// Contagem de algo bom(verificar máximo de saldo positivo)

// Resumindo

// Use Kadane sempre que você tiver:
// Uma sequência linear (array, série temporal).
// Quer um segmento contínuo (subarray).
// E precisa de um score acumulado máximo (soma, saldo, energia, etc.).

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int currentSum = nums[0];
        int maxSum = nums[0]; // inicia as variáveis da soma atual e da maxima com a primeira posição do array

        // quando você inicia as variaveis fora com a primeira posição do array, não se repete essa posição ao iterar o laço, então inicie i=1, que pega a próxima posição

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);// Math.Max vai comparar 2 valores e devolver o que for maior, a cada iteração somando valores ao currentSum

            maxSum = Math.Max(maxSum, currentSum); // vai comparar com o max e atualizar o global
        }

        return maxSum;
    }
}