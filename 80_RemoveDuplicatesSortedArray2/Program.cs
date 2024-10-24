namespace _80_RemoveDuplicatesSortedArray2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RemoveDuplicates([1,1,1,2,2,3]));
        
    }
    public static int RemoveDuplicates(int[] nums)
    {
        int i = 0;
        foreach (var num in nums)
        {
            if (i < 2 || num > nums[i - 2]) // i < 2 is for the first two elements
            {
                nums[i] = num; // replace the element at i with the current element
                i++; 
            }
        }
        return i;
    }
}
