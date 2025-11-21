class Program
{
    public static void preencheMatriz(int linha, int coluna, int[,] m)
    {
        int minValue = 0;
        int maxValue = 10;

        Random rand = new Random();

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                m[i, j] = rand.Next(minValue, maxValue);
            }
        }
    }

    public static void imprimeMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int m, n, o, p;

        Console.WriteLine("Digite o número de linhas da matriz 1:");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o número de colunas da matriz 1:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o número de linhas da matriz 2:");
        o = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o número de colunas da matriz 2:");
        p = Convert.ToInt32(Console.ReadLine());

        int[,] matriz1 = new int[m, n];
        int[,] matriz2 = new int[o, p];
        int[,] matrizResultante = new int[m, p];


        preencheMatriz(m, n, matriz1);
        preencheMatriz(o, p, matriz2);


        Console.WriteLine("\nMatriz 1:");
        imprimeMatriz(matriz1);
        Console.WriteLine("\n Matriz 2:");
        imprimeMatriz(matriz2);

        if (n == o)
        {
            int u = 0;


            for (int i = 0; i < matrizResultante.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResultante.GetLength(1); j++)
                {
                    int sum = 0;
                    while (u < n)
                    {
                        sum += matriz1[i, u] * matriz2[u, j];
                        u++;
                    }
                    u = 0;
                    matrizResultante[i, j] = sum;
                }
            }

            Console.WriteLine("Matriz Resultante:");
            imprimeMatriz(matrizResultante);
        }
        else
        {
            Console.WriteLine("\n Multiplicação não pode ser feita");
        }



    }

}