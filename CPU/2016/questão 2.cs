using System;

class Program
{
    static void Main(string[] args)
    {
        int birthDay, birthMonth, birthYear = 0;
        int days = 0;
        int actualDay = 7;
        int actualMonth = 11;
        int actualYear = 2016;

        Console.WriteLine("Digite sua data de nascimento no formato dd/mm/aaaa");
        console.ReadLine(birthDay, birthMonth, birthYear);

        while (birthDay < actualDay || birthMonth < actualMonth || birthYear < actualYear)
        {
            days++;
            birthDay++;
            if (birthDay > 30)
            {
                birthDay = 1;
                birthMonth++;
                if (birthMonth > 12)
                {
                    birthMonth = 1;
                    birthYear++;
                }
            }
        }

        double bioCicle = days % 14;
        switch (bioCicle)
        {
            case == 0:
                Console.WriteLine("NEGATIVO ZERADO POSITIVO");
                break;
            case < 11.5:
                Console.WriteLine("POSITIVO POSITIVO POSITIVO");
                break;
            case == 11.5:
                Console.WriteLine("ZERADO POSITIVO POSITIVO");
                break;
            case > 16.5:
                console.WriteLine("NEGATIVO NEGATIVO NEGATIVO");
                break;
            case == 16.5:
                Console.WriteLine("NEGATIVO NEGATIVO ZERADO");
        }
    }
}