namespace src.problems.arrays
{
    public class SetMismatch
    {
        public static void Run()
        {
            FindErrorNums([1, 2, 2, 4]);
        }
        
        public static int[] FindErrorNums(int[] nums) {
            int[] newNums = new int[2];
            bool[] seen = new bool[nums.Length + 1];

            foreach (int num in nums)
            {
                if (seen[num])
                    newNums[0] = num;
                else
                    seen[num] = true;
            }

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!seen[i])
                {
                    newNums[1] = i;        
                    break;
                }
            }

            return newNums;
        }
    }
}