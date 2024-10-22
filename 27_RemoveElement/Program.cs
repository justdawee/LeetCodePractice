namespace _27_RemoveElement;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RemoveElement([3,2,2,3], 3));
    }
    
    public static int RemoveElement(int[] nums, int val) 
    {
        int i = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] != val) // if the value is not equal to the target value
            {
                nums[i] = nums[j]; // replace the current value with the value at the current index
                i++;
            }
        }
        return i; // return the length of the new array
    }
}
