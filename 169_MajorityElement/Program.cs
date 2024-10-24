namespace _169_MajorityElement;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MajorityElement([2,2,1,1,1,2,2,3,3,3,3,3]));
    }
    
    public static int MajorityElement(int[] nums)
    {
        int count = 0;
        int majority = 0; 
        
        foreach (var num in nums)
        {
            if (count == 0)
            {
                majority = num;
            }

            if (num == majority)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return majority;
    }
}
