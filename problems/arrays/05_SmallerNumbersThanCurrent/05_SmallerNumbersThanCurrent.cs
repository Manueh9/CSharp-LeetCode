namespace src.problems.arrays
{
    public static class SmallerNumbersThanCurrent
    {
        public static void Run()
        {
            FindSmallerNumbersThanCurrent([8,1,2,2,3]);
        }
            
        public static int[] FindSmallerNumbersThanCurrent(int[] nums)
        {
            int[] numsSmaller = new int[nums.Length];
            
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (num > nums[j])
                    {
                        numsSmaller[i]++;
                    }
                        
                }
                
            }
            
            Console.WriteLine(string.Join(", ", numsSmaller));
            return numsSmaller;
        }
    }
    
}

