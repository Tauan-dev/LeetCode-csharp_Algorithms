using System;
using System.Collections.Generic;
using System.Numerics;

class Program

{
    public static BigInteger Expo(int value)
    {
        return BigInteger.Pow(value, value);
    }

    static void Main(string[] args)
    {
        BigInteger total = 0;

        int[] num = new int[5] { 1, 3, 6, 10, 11 };

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > 0 && num[i] < 1000000)
            {
                total = Expo(num[i]);

                int k = num[i].ToString().Length;

                BigInteger resto = BigInteger.Pow(10, k);

                BigInteger ultimosDigitos = total % resto;

                if (ultimosDigitos == num[i])
                {
                    Console.WriteLine("SIM");
                }
                else
                {
                    Console.WriteLine("NÃO");
                }
            }
            else
            {
                Console.WriteLine("Número fora do escopo");
            }
        }
    }
}
