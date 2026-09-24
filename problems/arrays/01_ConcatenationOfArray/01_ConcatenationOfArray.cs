namespace src.problems.arrays{

    public static class ConcatenationOfArray
    {
        public static void Run()
        {
            GetConcatenation([1,2,1]);
        }

        public static int[] GetConcatenation(int[] nums) {
            int[] numsFormated = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                numsFormated[i] = nums[i];
                numsFormated[nums.Length + i] = nums[i];
            }

            Console.WriteLine(string.Join(", ", numsFormated));
            return numsFormated;
        }
    }
}
