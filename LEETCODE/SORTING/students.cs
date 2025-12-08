using System;

public class Student
{
    public int[] Register;
    public double[] Nota;

    public Student(int[] register, double[] nota)
    {
        Register = register;
        Nota = nota;
    }
}

class Solution
{
    public int[] Matriculas(Student estudante)
    {
        int[] matriculas = new int[estudante.Register.Length];
        Array.Copy(estudante.Register, matriculas, estudante.Register.Length); // Copia os dados
        QuickSort(matriculas, 0, matriculas.Length - 1);
        return matriculas;
    }

    public double[] Notas(Student estudante)
    {
        double[] notas = new double[estudante.Nota.Length];
        Array.Copy(estudante.Nota, notas, estudante.Nota.Length); // Copia os dados
        QuickSortDouble(notas, 0, notas.Length - 1); // Ordena double[]
        return notas;
    }

    // QuickSort para int[]
    public void QuickSort(int[] nums, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(nums, left, right);
            QuickSort(nums, left, pivot - 1);
            QuickSort(nums, pivot + 1, right);
        }
    }

    public int Partition(int[] vetor, int left, int right)
    {
        int pivot = vetor[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (vetor[j] < pivot)
            {
                i++;
                (vetor[i], vetor[j]) = (vetor[j], vetor[i]);
            }
        }

        (vetor[i + 1], vetor[right]) = (vetor[right], vetor[i + 1]);
        return i + 1;
    }

    // QuickSort para double[]
    public void QuickSortDouble(double[] nums, int left, int right)
    {
        if (left < right)
        {
            int pivot = PartitionDouble(nums, left, right);
            QuickSortDouble(nums, left, pivot - 1);
            QuickSortDouble(nums, pivot + 1, right);
        }
    }

    public int PartitionDouble(double[] vetor, int left, int right)
    {
        double pivot = vetor[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (vetor[j] < pivot)
            {
                i++;
                (vetor[i], vetor[j]) = (vetor[j], vetor[i]);
            }
        }

        (vetor[i + 1], vetor[right]) = (vetor[right], vetor[i + 1]);
        return i + 1;
    }

    public static void Main(string[] args)
    {
        var sol = new Solution();
        Student estudante = new Student(
            new int[] { 102, 101, 104, 103 },
            new double[] { 8.5, 9.5, 7.5, 10.0 }
        );

        var sortedMatriculas = sol.Matriculas(estudante);
        var sortedNotas = sol.Notas(estudante);

        Console.WriteLine("Sorted Matriculas: " + string.Join(", ", sortedMatriculas));
        Console.WriteLine("Sorted Notas: " + string.Join(", ", sortedNotas));
    }
}