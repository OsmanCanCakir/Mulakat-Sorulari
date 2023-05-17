
using System;
public class Solution
{
    public  bool KopyaIcerirMi(int[] nums)
    {
        List<int> set = new List<int>();  
        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
            set.Add(num);
        }
        return false;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1,1,1,3,3,4,3,2,4,2 }; //İstediğiniz şekilde nums array'ini değiştirebilirsiniz.

        //int[] nums = { 1, 2, 3, 4 };
        //int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2};

        Solution solution = new Solution();
        bool result = solution.KopyaIcerirMi(nums);
        Console.WriteLine("Çıktı: " + result);
    }
}
