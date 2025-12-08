// vai dar erro em alguns casos pois ele não pega a questão de comprar na baixa e vender na alta, e sim do menor valor do array pra frente, deu certo para um caso de teste, mas vai dar erro em outros

class Solution
{
    public static int maxProfit(int[] prices)
    {

        int result = 0;


        for (int i = 0; i < prices.Length; i++)
        {
            int minPrice = prices.Min(); // aqui também não precisa declarar a variavel fora do escopo do metodo, além de que o Min() já retorna um inteiro, então não há necessidade de inicializar a variavel com 0

            if (prices[i] == minPrice)
            {
                int aux = i; // não precisa declarar esas variavel fora do escopo do if/laço (isso pode gerar confusão somente), evite fazer isso
                int skipNumber = prices.Length - aux;
                int maxSubArray = prices.Skip(aux).Take(skipNumber).Max(); // esses metodos vão pegar uma sub array dentro de price, onde .Skip vai pular as posições do array, tipo int[] array = {10,2,12,4,7,6}, caso meu skip seja 3, meu novo sub array vai ser {4,7,6}, e o take vão ser a quantidade de casas a frente você quer, ou seja caso fosse Take(2), meu novo sub array seria {4,7}
                result = maxSubArray - minPrice;

            }

        }

        return result;
    }

    public static void Main(string[] args)
    {
        int result =
        maxProfit(new int[]
            {7, 1, 5, 3, 6, 4});
        Console.WriteLine(result);
    }
}