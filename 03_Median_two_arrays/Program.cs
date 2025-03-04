

public class Program
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
         if (nums1.Length > nums2.Length) {
            int[] temp = nums1;
            nums1 = nums2;
            nums2 = temp;
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int left = 0, right = m;
        int halfLen = (m + n + 1) / 2;

        while (left <= right) {
            int i = (left + right) / 2;
            int j = halfLen - i;

            if (i < m && nums2[j - 1] > nums1[i]) {
                
                left = i + 1;
            } else if (i > 0 && nums1[i - 1] > nums2[j]) {
                
                right = i - 1;
            } else {
                
                int maxLeft = 0;
                if (i == 0) {
                    maxLeft = nums2[j - 1];
                } else if (j == 0) {
                    maxLeft = nums1[i - 1];
                } else {
                    maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]);
                }

                if ((m + n) % 2 == 1) {
                    return maxLeft;
                }

                int minRight = 0;
                if (i == m) {
                    minRight = nums2[j];
                } else if (j == n) {
                    minRight = nums1[i];
                } else {
                    minRight = Math.Min(nums1[i], nums2[j]);
                }

                return (maxLeft + minRight) / 2.0;
            }
        }

        return 0.0;
    }

    static void Main()
    {
        int[] num1 = new int[]{
            1,
            2
        };
        int[] num2 = new int[]{
            3,
            4
        };
        System.Console.WriteLine(FindMedianSortedArrays(num1, num2));

    }
}