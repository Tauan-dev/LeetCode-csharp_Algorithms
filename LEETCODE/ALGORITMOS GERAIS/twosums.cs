public class Solution
{
    public int[] TwoSum(int[] nums, int target) // dentro do metodo, vão ser utilizado dois parametros, um array de inteiros e um inteiro alvo
    {
        int aux = 0;
        int pos = 0;
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++) //dentro do laço, verificamos se suas posições são menores que o alvo do parametro
        {
            if (nums[i] < target) // caso o valor seja menor
            {
                aux = target - nums[i]; // um valor auxiliar vai guardar a subtração do alvo pela posição que é menor
                pos = i; // posição vai guardar a posição onde esse valor está 
            }
            if (aux == nums[i]) // quando encontramos outro valor no array que seja igual ao resultado da subtração
            {
                aux = i; // atualizamos a variavel aux com a posição
            }
        }

        // colocamos as posições achadas dentro de um array resultado
        result[0] = pos;
        result[1] = aux;

        return result; // retornamos o array de resultado, dado que é um metodo!
    }

    public static void Main(string[] args)
    {
        int[] result = new Solution().TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}