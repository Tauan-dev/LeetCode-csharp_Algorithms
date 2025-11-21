using System;

class URI
{

    static void Main(string[] args)
    {

        int tea = 4;
        int[] vote = new int[5] { 2, 2, 1, 4, 5 };
        int correct = 0;

        for (int i = 0; i < vote.Length; i++)
        {
            if (tea == vote[i])
            {
                correct++;
            }
        }

        Console.WriteLine(correct);

    }

}