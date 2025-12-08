public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        int result = 0;
        Dictionary<int, int> counter = new Dictionary<int, int>();
        counter[nums[0]] = 1;
        int i = 0;
        while (i < nums.Length - 1) // dado que você inicia fora  do laço, a ultima posição percorrida é o ultimo valor do array
        {
            i++;
            if (counter.ContainsKey(nums[i]))
            {
                counter[nums[i]]++;
                result = nums[i]; // eu quero o valor, não quantas vezes ele foi contado
            }
            else
            {
                counter[nums[i]] = 1;
            }


        }

        return result;
    }

    public static void Main(string[] args)
    {
        var sol = new Solution();
        int[] nums = new int[] { 3, 1, 3, 4, 2 };
        var result = sol.FindDuplicate(nums);

        Console.WriteLine(result);
    }
}