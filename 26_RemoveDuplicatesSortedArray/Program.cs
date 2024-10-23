namespace _26_RemoveDuplicatesSortedArray;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RemoveDuplicates([0,0,1,1,1,2,2,3,3,4]));
    }
    
    public static int RemoveDuplicates(int[] nums)
    {
        int i = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            if (i == 0 || nums[j] != nums[i - 1]) 
            {
                nums[i++] = nums[j];
            }
        }
        return i;
    }
}
