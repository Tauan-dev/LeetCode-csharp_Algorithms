class Solution
{
    public int[,] generateGrade(string[,] prova, string[] gabarito)
    {
        int[,] result = new int[5, 1];

        int sum = 0;

        for (int i = 0; i < prova.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0; j < prova.GetLength(1); j++)
            {
                if (prova[i, j] == gabarito[j])
                {
                    sum++;
                    result[i, 0] = sum; // valor de j dado que é somente uma coluna, sempre sera 0
                }
            }
        }


        return result;

    }

    public static void Main(string[] args)
    {
        var solution = new Solution();
        string[,] prova = new string[5, 10] {
                                    { "b", "a", "c", "d", "a", "c", "a", "b", "b", "d" },
                                    { "b", "a", "c", "d", "b", "d", "a", "a", "b", "d" },
                                    { "b", "d", "c", "d", "e", "a", "b", "b", "a", "a" },
                                    { "a", "d", "b", "c", "a", "c", "d", "b", "b", "a" },
                                    { "a", "a", "b", "d", "e", "d", "a", "b", "b", "a" } };
        string[] gabarito = new string[10] { "a", "d", "b", "c", "a", "c", "d", "b", "b", "a" };
        int[,] resultado = solution.generateGrade(prova, gabarito);

        Console.WriteLine("Notas dos alunos:");
        for (int i = 0; i < resultado.GetLength(0); i++)
        {
            Console.WriteLine("Aluno " + (i + 1) + ": " + resultado[i, 0] + " pontos");
        }
    }
}