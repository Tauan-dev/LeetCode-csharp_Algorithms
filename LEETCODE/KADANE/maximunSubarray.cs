public class Solution
// quando o problema não pede alguma restriçãod e contéudo ( exemplio : o maximo de K números impares, ou um subvetor/substring sem repetir elementos), não necessita de sliding window
// o algoritmo utilizado aqui é o de Kadane, que não tem restrição, só quer a maior soma contínua 
{
    public int MaxSubArray(int[] nums)
    {
        int l = 0;
        int sum = 0;
        int maxSum = 0;

        //não precisa do dicionário

        for (int r = 0; r < nums.Length; r++) // r percorre o array
        {
            sum += nums[r]; // vai somando as posições do vetor 
            if (maxSum < sum) // caso a soma for maior que o maxSum, o maxSum vai receber o valor da soma 
            {
                maxSum = sum;
            }

            while (sum < 0 && l <= r) // caso a soma tenha ficado negativa
            {
                sum -= nums[l]; // remove o elemento da esquerda da janela de soma 
                l++; // move o ponteiro um passo a frente 
            }
            // dessa forma enquanto a soma continuar negativa, ele vai limpar os valores a esqueda do vetor
        }

        return maxSum;
    } // essa forma até resolve o problema, mas não é a mais eficiente, nem funciona em todos os casos para isso vou implementar o Kadane clássico

    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int result = sol.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        Console.WriteLine(result);
    }
}