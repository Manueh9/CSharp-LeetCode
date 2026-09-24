namespace src.problems.arrays
{
    public static class FindMaxConsecutiveOnes
    {
        public static void Run()
        {
            FindMaxConsecutiveOne([1,0,1,1,1,0,1,1,0,1]);
        }
        
        public static int FindMaxConsecutiveOne(int[] nums)
        {
            int max = 0;
            int current = 0;

            foreach (int num in nums) {
                if (num == 1) {
                    current++;
                    if (current > max)
                        max = current;
                } else {
                    current = 0;
                }
            }

            return max;
        }
    }
    
    
}