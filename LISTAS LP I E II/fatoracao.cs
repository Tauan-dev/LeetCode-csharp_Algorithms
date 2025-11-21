using System;

class Program
{

    static double[,] CalcularInversa(double[,] L, double[,] U)
    {
        int n = L.GetLength(0);
        double[,] inversa = new double[n, n];

        for (int coluna = 0; coluna < n; coluna++)
        {
            double[] identidade = new double[n];
            identidade[coluna] = 1;

            double[] y = SubstituicaoProgressiva(L, identidade);
            double[] x = SubstituicaoRegressiva(U, y);

            for (int i = 0; i < n; i++)
                inversa[i, coluna] = x[i];
        }

        return inversa;
    }


    static double[] SubstituicaoProgressiva(double[,] L, double[] b)
    {
        int n = L.GetLength(0);
        double[] y = new double[n];

        for (int i = 0; i < n; i++)
        {
            double soma = 0;
            for (int j = 0; j < i; j++)
                soma += L[i, j] * y[j];
            y[i] = b[i] - soma;
        }

        return y;
    }


    static double[] SubstituicaoRegressiva(double[,] U, double[] y)
    {
        int n = U.GetLength(0);
        double[] x = new double[n];

        for (int i = n - 1; i >= 0; i--)
        {
            double soma = 0;
            for (int j = i + 1; j < n; j++)
                soma += U[i, j] * x[j];
            x[i] = (y[i] - soma) / U[i, i];
        }

        return x;
    }


    static double[,] MultiplicarMatrizes(double[,] A, double[,] B)
    {
        int n = A.GetLength(0);
        double[,] C = new double[n, n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                    C[i, j] += A[i, k] * B[k, j];

        return C;
    }


    static void ImprimirMatriz(double[,] M)
    {
        int linhas = M.GetLength(0);
        int colunas = M.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
                Console.Write($"{M[i, j],8:F2} ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        double[,] matrizA = {
            { 1, 1, 0, 0 },
            { 0, 4, 0, 0 },
            { 0, 3, 1, 0 },
            { 0, 2, 0, 1 }
        };

        int n = 4;

        double[,] L = new double[n, n];
        double[,] U = new double[n, n];


        for (int i = 0; i < n; i++)
            L[i, i] = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                double soma = 0;
                for (int k = 0; k < i; k++)
                    soma += L[i, k] * U[k, j];
                U[i, j] = matrizA[i, j] - soma;
            }


            for (int j = i + 1; j < n; j++)
            {
                double soma = 0;
                for (int k = 0; k < i; k++)
                    soma += L[j, k] * U[k, i];
                L[j, i] = (matrizA[j, i] - soma) / U[i, i];
            }
        }

        Console.WriteLine("Matriz L:");
        ImprimirMatriz(L);

        Console.WriteLine("Matriz U:");
        ImprimirMatriz(U);


        double[,] inversa = CalcularInversa(L, U);
        Console.WriteLine("Matriz inversa A⁻¹:");
        ImprimirMatriz(inversa);

        Console.WriteLine("Verificação (A * A⁻¹):");
        ImprimirMatriz(MultiplicarMatrizes(matrizA, inversa));
    }

}
