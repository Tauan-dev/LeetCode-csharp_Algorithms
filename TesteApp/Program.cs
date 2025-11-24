// Dado um array numsde tamanho n, retorne o elemento majoritário .

// O elemento majoritário é aquele que aparece mais de um ⌊n / 2⌋número de vezes. Pode-se assumir que o elemento majoritário sempre existe no array.


public class Solution
{
    public static int MajorityElement(int[] nums)
    {
        int major = 0;
        int index = 0;
        Dictionary<int, int> counter = new Dictionary<int, int>();
        counter[nums[0]] = 1; // inicia a primeira posição do dicionário, dando o valor de 1 (ou seja uma ocorrência)

        while (index < nums.Length - 1)
        {
            index++;
            if (counter.ContainsKey(nums[index]))
            {
                counter[nums[index]]++; // se esse numero existir, vai ser adicionado uma ocorrencia a sua chave, tipo se 1 existir e tiver 1 inserção feita, após esse passo ficaria <1 , 2>  
            }
            else
            {
                counter[nums[index]] = 1; // caso não exista, cria uma ocorrencia / par no dicionário
            }

        }

        foreach (int num in counter.Values)
        {
            if (num > major)
            {
                major = num;
            }
        }

        var chave = counter.FirstOrDefault(x => x.Value == major).Key;

        return chave;
    }

    public static void Main(string[] args)
    {
        int result = MajorityElement(new int[] { 3, 2, 3 });
        Console.WriteLine(result);
    }
}