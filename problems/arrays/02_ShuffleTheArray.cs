namespace src.problems.arrays{

    public static class ShuffleTheArray{
        public static void Run()
        {
            Shuffle([2,5,1,3,4,7], 3);
        }

        public static int[] Shuffle(int[] nums, int n) {
            int[] result = new int[2 * n];

            for (int i = 0; i < n; i++)
            {
                result[2 * i] = nums[i];
                result[2 * i + 1] = nums[i + n];
            }

            Console.WriteLine(string.Join(", ", result));
            return result;
        }

    }

}
