public class Solution
{
    public int CountTriples(int n)
    {
        int counter = 0;

        for (int a = 1; a <= n; a++)
        {
            for (int b = 1; b <= n; b++)
            {
                int sum = a * a + b * b;
                int c = (int)Math.Sqrt(sum);

                if (c * c == sum && c <= n)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
}
