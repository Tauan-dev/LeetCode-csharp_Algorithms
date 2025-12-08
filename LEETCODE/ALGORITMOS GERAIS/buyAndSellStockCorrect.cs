class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue; // intMaxValue é o maior numero possivel declarado como inteito 
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice) // vai verificar se a posiçaõ do array é o menor preço 
            {
                minPrice = prices[i];  // caso seja atualiza o menor preço até agora
            }
            else
            {
                int profit = prices[i] - minPrice; // verifica o lucro se vender nessa posição
                if (profit > maxProfit) // se o lucro for maior que o maior lucro até agora
                {
                    maxProfit = profit;  // atualiza o maior lucro
                }
            }
        }

        return maxProfit;
    }
}