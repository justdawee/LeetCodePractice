namespace _88_MergeSortedArray;

class Program
{
    static void Main(string[] args)
    {
        Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
    }
    
    public static void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int i = m - 1; // last index of nums1
        int j = n - 1; // last index of nums2
        int k = m + n - 1; // last index of merged array
        
        while (i >= 0 && j >= 0) // while both arrays have elements
        {
            if (nums1[i] > nums2[j]) // if nums1 has greater element
            {
                nums1[k] = nums1[i]; // copy it to the end of nums1
                i--;
            }
            else // if nums2 has greater element
            {
                nums1[k] = nums2[j]; // copy it to the end of nums1
                j--;
            }
            k--;
        }
        
        while (j >= 0) // if there are elements left in nums2
        {
            nums1[k] = nums2[j]; // copy them to the end of nums1
            j--;
            k--;
        }
    }
}
